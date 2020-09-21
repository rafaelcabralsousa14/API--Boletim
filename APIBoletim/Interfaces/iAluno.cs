﻿using APIBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Interfaces
{
    interface iAluno
    {
        List<Aluno> ListarTodos();
        Aluno BuscarPorID(int id);
        Aluno Cadastrar(Aluno a);
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);
    }
}
