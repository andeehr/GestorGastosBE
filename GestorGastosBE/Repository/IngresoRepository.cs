using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository
{
    public class IngresoRepository : IIngresoRepository
    {
        private readonly GGContext _context;

        public IngresoRepository(GGContext context)
        {
            _context = context;
        }

        public void Delete(int? id)
        {
            var result = _context.Ingresos.SingleOrDefault(s => s.Id == id);
            if (result == null) {
                throw new Exception("El ingreso no existe");
            }
            _context.Remove(result);
            _context.SaveChanges();
        }

        public IEnumerable<Ingreso> GetAll()
        {
            return _context.Ingresos.Include(g => g.Medio)
                            .Include(g => g.CategoriaIngreso)
                            .AsEnumerable();
        }

        public Ingreso GetById(int id)
        {
            return _context.Ingresos.Include(g => g.Medio)
                            .Include(g => g.CategoriaIngreso)
                            .SingleOrDefault(s => s.Id == id);
        }

        public Ingreso Insert(Ingreso entity)
        {
            Validate(entity);
            _context.Ingresos.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Ingreso Update(Ingreso entity)
        {
            Validate(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        private void Validate(Ingreso entity)
        {
            if (entity == null) {
                throw new ArgumentNullException("entity");
            }

            if (!_context.Medios.Any(v => v.Id == entity.IdMedio)) {
                throw new Exception("El medio no existe");
            }

            if (!_context.CategoriasIngreso.Any(v => v.Id == entity.IdCategoriaIngreso)) {
                throw new Exception("La categoria no existe");
            }
        }
    }
}
