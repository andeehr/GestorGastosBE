using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GestorGastosBE.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly GGContext context;

        public GenericRepository(GGContext context)
        {
            this.context = context;
        }

        protected DbSet<T> DbSet => context.Set<T>();

        public T Add(T entity)
        {
            return DbSet.Add(entity).Entity;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = GetAll().Where(predicate);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public T FindSingleBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return FindBy(predicate, includes).SingleOrDefault();
        }

        public void Remove(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
    }
}
