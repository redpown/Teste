using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDev.Contratos;
using TesteDev.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteDev.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanchesController : ControllerBase
    {
        private readonly ILanchesRepositorio _ILanchesRepositorio;
        //para que eu posso intanciar classes de outro projeto dentro da minha aplicacao
        //preciso ir em services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        //no Startup.cs
        public LanchesController(ILanchesRepositorio iLanchesRepositorio)
        {
            _ILanchesRepositorio = iLanchesRepositorio;
        }
        // GET: api/Lanches
        [HttpGet]
        public IEnumerable<Lanches> Get()
        {

            return _ILanchesRepositorio.ObterTodos();
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdutosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
