using TesteDev.Contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TesteDev.Repository;
using TesteDev.Entidades;
using TesteDev.Repository.Contexto;

namespace TestDev.Repositorios
{
    public class IngredientesRepositorio : BaseRepositorio<Ingredientes>, IIngredientesRepositorio
    {
        protected readonly TesteDevContexto _TesteDev;
        public IngredientesRepositorio(TesteDevContexto testeDev) : base(testeDev)
        {
            _TesteDev = testeDev;
        }

        public Ingredientes Obter(string ingredienete)
        {
            
            return _TesteDev.Ingredientes.FirstOrDefault(u => u.ingrediente == ingredienete);
        }

        
    }
}
