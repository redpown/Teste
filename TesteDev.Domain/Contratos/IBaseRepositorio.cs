using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TesteDev.Contratos
{
    public interface IBaseRepositorio<Tentity> : IDisposable where Tentity : class
    {

        public void Adicionar(Tentity entity);
        public Tentity ObterPorId(int id);
        public IEnumerable<Tentity> ObterTodos();
        public IEnumerable<Tentity> Buscar(Expression<Func<Tentity, bool>> predicate);
        public void Atualizar(Tentity entity);
        public void Remover(Tentity entity);


    }
}