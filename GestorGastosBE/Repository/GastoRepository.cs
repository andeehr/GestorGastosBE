using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository
{
    public class GastoRepository :IGastoRepository
    {
        private readonly GGContext _context;

        public GastoRepository(GGContext context)
        {
            _context = context;
        }

        public void Delete(int? id)
        {
            var result = _context.Gastos.SingleOrDefault(s => s.Id == id);
            if (result == null) {
                throw new Exception("El gasto no existe");
            }
            _context.Remove(result);
            _context.SaveChanges();
        }

        public IEnumerable<Gasto> GetAll()
        {
            return _context.Gastos.Include(g => g.Medio)
                            .Include(g => g.SubcategoriaGasto)
                            .AsEnumerable();
        }

        public Gasto GetById(int id)
        {
            return _context.Gastos.Include(g => g.Medio)
                            .Include(g => g.SubcategoriaGasto)
                            .SingleOrDefault(s => s.Id == id);
        }

        public Gasto Insert(Gasto entity)
        {
            Validate(entity);
            _context.Gastos.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Gasto Update(Gasto entity)
        {
            Validate(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        private void Validate(Gasto entity)
        {
            if (entity == null) {
                throw new ArgumentNullException("entity");
            }

            if (!_context.Medios.Any(v => v.Id == entity.IdMedio)) {
                throw new Exception("El medio no existe");
            }

            if (!_context.SubcategoriasGasto.Any(v => v.Id == entity.IdSubcategoria)) {
                throw new Exception("La subcategoria no existe");
            }
        }
    }
}
