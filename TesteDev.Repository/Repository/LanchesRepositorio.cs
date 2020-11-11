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
    public class LanchesRepositorio : BaseRepositorio<Lanches>, ILanchesRepositorio
    {
        protected readonly TesteDevContexto _TesteDev;
        public LanchesRepositorio(TesteDevContexto testeDev) : base(testeDev)
        
        {
            _TesteDev = testeDev;
        }

        public Lanches Obter(string lanche)
        {

            return _TesteDev.Lanches.FirstOrDefault(u => u.lanche == lanche);
        }

            }
}
