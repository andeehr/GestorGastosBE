using GestorGastosBE.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GestorGastosBE.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        T FindSingleBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        void Remove(T entity);
        IQueryable<T> GetAll();
    }
}