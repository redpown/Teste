using TesteDev.Repository.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TesteDev.Contratos;
using Microsoft.EntityFrameworkCore;

namespace TesteDev.Repository
{

    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {

        protected readonly TesteDevContexto _TesteDev;
        public BaseRepositorio(TesteDevContexto testeDev)
        {

            _TesteDev = testeDev;
        }

        public void Adicionar(Tentity entity)
        {
            _TesteDev.Set<Tentity>().Add(entity);
            _TesteDev.SaveChanges();
        }

        public void Atualizar(Tentity entity)
        {
            _TesteDev.Set<Tentity>().Update(entity);
            _TesteDev.SaveChanges();
        }

        public void Dispose()
        {
            _TesteDev.Dispose();
        }

        public Tentity ObterPorId(int id)
        {
            return _TesteDev.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> Buscar(Expression<Func<Tentity, bool>> predicate)
        {
            return _TesteDev.Set<Tentity>().AsNoTracking().Where(predicate).ToList();
        }
        public IEnumerable<Tentity> ObterTodos()
        {
            return _TesteDev.Set<Tentity>().ToList();
        }

        public void Remover(Tentity entity)
        {
            _TesteDev.Remove(entity);
            _TesteDev.SaveChanges();
        }


    }
}
