using System;
using System.Collections.Generic;
using System.Text;
using TesteDev.Entidades;

namespace TesteDev.Contratos
{
    public interface IIngredientesRepositorio : IBaseRepositorio<Ingredientes>
    {
        public Ingredientes Obter(string ingredienete);
    }
}
