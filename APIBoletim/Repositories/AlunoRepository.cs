using APIBoletim.Context;
using APIBoletim.Domains;
using APIBoletim.Interfaces;
using Microsoft.AspNetCore.Connections.Features;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Repositories
{
    public class AlunoRepository : iAluno
    {
        public Aluno Alterar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno BuscarPorID()
        {
            throw new NotImplementedException();
        }

        public Aluno Cadastrar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno Excluir(Aluno a)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
