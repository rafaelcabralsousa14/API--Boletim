using APIBoletim.Context;
using APIBoletim.Domains;
using APIBoletim.Interfaces;
using Microsoft.AspNetCore.Connections.Features;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace APIBoletim.Repositories
{
    public class AlunoRepository : iAluno
    {
        BoletimContext conexao = new BoletimContext();

        SqlCommand cmd = new SqlCommand();

        public Aluno Alterar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno BuscarPorID(int id)
        {
            cmd.Connection = conexao.Conectar();
            
            cmd.CommandText = "SELECT * FROM Aluno WHERE IdAluno = @id";

            cmd.Parameters.AddWithValue("@id", id);
            
            SqlDataReader dados = cmd.ExecuteReader();

            Aluno a = new Aluno();

            while(dados.Read()){
                a.IdAluno = Convert.ToInt32(dados.GetValue(0));
                a.Nome = dados.GetValue(1).ToString();
                a.RA = dados.GetValue(2).ToString();
                a.Idade = Convert.ToInt32(dados.GetValue(3));
            }

            conexao.Desconectar();

            return a;
        }

        public Aluno Cadastrar(Aluno a)
        {
            cmd.Connection = conexao.Conectar();
            
            cmd.CommandText = "INSERT INTO Aluno " +
                "(Nome, Ra, Idade)" +
                "VALUES" +
                "(@nome, @ra, @idade)";

            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@ra", a.RA);
            cmd.Parameters.AddWithValue("@idade", a.Idade);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();

            return a;
        }

        public Aluno Excluir(Aluno a)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> ListarTodos()
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM Aluno";
            SqlDataReader dados = cmd.ExecuteReader();
            List<Aluno> alunos = new List<Aluno>();
            
            while(dados.Read()){
                alunos.Add(
                    new Aluno(){
                        IdAluno = Convert.ToInt32(dados.GetValue(0)),
                        Nome = dados.GetValue(1).ToString(),
                        RA = dados.GetValue(2).ToString(),
                        Idade = Convert.ToInt32(dados.GetValue(3))
                    }
                );
            }

            conexao.Desconectar();

            return alunos;
        }
    }
}
