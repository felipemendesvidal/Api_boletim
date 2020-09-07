using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boletimApi.domains;
using boletimApi.repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace boletimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {



        AlunoRepositori repo = new AlunoRepositori();

        // GET: api/<AlunoController>
        [HttpGet]
        public List<Aluno> Get()
        {
            return repo.LerTodos();
        }

        // GET: api/<AlunoController>
        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return repo.BuscarID(id);
        }

        // POST api/<AlunoController>
        [HttpPost]
        public Aluno Post([FromBody] Aluno novoAluno)
        {
            return repo.Cadastrar(novoAluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno a)
        {
            return repo.Alterar(id, a);
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }


    }
}
