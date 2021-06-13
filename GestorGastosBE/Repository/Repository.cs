using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository
{
    public class Repository<T> :IRepository<T> where T : BaseEntity
    {
        protected readonly GGContext _context;
        private DbSet<T> entity;
        public Repository(GGContext context)
        {
            this._context = context;
            entity = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }
        public T GetById(int id)
        {
            return entity.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null) {
                throw new ArgumentNullException("entity");
            }

            this.entity.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null) {
                throw new ArgumentNullException("entity");
            }

            _context.SaveChanges();
        }
        public void Delete(int? id)
        {
            if (id == null) {
                throw new ArgumentNullException("entity");
            }

            var result = entity.SingleOrDefault(s => s.Id == id);
            this.entity.Remove(result);
            _context.SaveChanges();
        }
    }
}
