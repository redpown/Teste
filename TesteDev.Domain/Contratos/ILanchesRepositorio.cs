using System;
using System.Collections.Generic;
using System.Text;
using TesteDev.Entidades;

namespace TesteDev.Contratos
{
    public interface ILanchesRepositorio : IBaseRepositorio<Lanches>
    {
        public Lanches Obter(string lanche);

    }
}
