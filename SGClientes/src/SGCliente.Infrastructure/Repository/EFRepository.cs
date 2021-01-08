using Microsoft.EntityFrameworkCore;
using SGCliente.ApplicationCore.Interfaces.Repository;
using SGCliente.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGCliente.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ClienteContext _dbcontext;

        public EFRepository(ClienteContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public TEntity Adicionar(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Add(entity);
            _dbcontext.SaveChanges();
            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbcontext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public TEntity ObterPorId(int id)
        {
            return _dbcontext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbcontext.Set<TEntity>().AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Remove(entity);
            _dbcontext.SaveChanges();
        }
    }
}
