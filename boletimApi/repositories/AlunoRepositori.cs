using boletimApi.context;
using boletimApi.domains;
using boletimApi.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace boletimApi.repositories
{
    public class AlunoRepositori : Ialunocs
    {
        boletemContext conexao = new boletemContext();

        //responsavel por colocar os comandos de sql
        SqlCommand cmd = new SqlCommand();

        public Aluno Alterar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public Aluno Cadastrar()
        {
            throw new NotImplementedException();
        }

        public Aluno Excluir(Aluno a)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> LerTodos()
        {
            conexao.conectar();

            cmd.CommandText = "select * from Aluno";
            SqlDataReader dados = cmd.ExecuteReader();
            List <Aluno> alunos = new List<Aluno>();
            while (dados.Read())
            {
                alunos.Add(new Aluno()
                {
                    IdAlunoy = Convert.ToInt32(dados.GetValue (0) ),
                    Nome =  dados.GetValue(1).ToString(),
                    RA = dados.GetValue(2).ToString(),
                    idade = Convert.ToInt32(dados.GetValue(3))


                }); 
            }
            conexao.desconectar();

            return alunos;
        }
    }
}
