using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteDev.Contratos;
using TesteDev.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteDev.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientesController : ControllerBase
    {
        private readonly IIngredientesRepositorio _IIngredientesRepositorio;
        public IngredientesController(IIngredientesRepositorio iIngredientesRepositorio)
        {
            _IIngredientesRepositorio = iIngredientesRepositorio;
        }
        // GET: api/Ingredientes
        [HttpGet]
        public IEnumerable<Ingredientes> Get()
        {

            return _IIngredientesRepositorio.ObterTodos();
        }

        // GET api/ingredientes/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/ingredientes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/ingredientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ingredientes InggredienteAtual)
        {
            _IIngredientesRepositorio.Atualizar(InggredienteAtual);
        }

        // DELETE api/ingredientes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IIngredientesRepositorio.Buscar(u=>u.id==id);
        }

        // HttpGet api/ingredientes/Buscar/{id}
        [HttpGet("Buscar/{texto}")]
        public IEnumerable<Ingredientes> Buscar(string texto)
        {
            /*W => EF.Functions.Like(W.Titulo, "%foni%")*/
            return _IIngredientesRepositorio.Buscar(W => EF.Functions.Like(W.ingrediente, "%" + texto + "%"));
        }
    }
}
