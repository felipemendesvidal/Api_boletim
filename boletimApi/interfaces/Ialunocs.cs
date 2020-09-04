using boletimApi.domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boletimApi.interfaces
{
    interface Ialunocs
    {
        List<Aluno> LerTodos();
        Aluno BuscarPorID(int id);
        Aluno Cadastrar();
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);
    }
}
