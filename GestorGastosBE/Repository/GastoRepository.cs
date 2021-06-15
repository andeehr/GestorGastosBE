using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository
{
    public class GastoRepository : IGastoRepository
    {
        private readonly GGContext _context;

        public GastoRepository(GGContext context)
        {
            _context = context;
        }

        public void Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gasto> GetAll()
        {
            return _context.Gastos.Include(g => g.Medio)
                            .Include(g=>g.SubcategoriaGasto)
                            .AsEnumerable();
        }

        public Gasto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Gasto Insert(Gasto entity)
        {
            throw new NotImplementedException();
        }

        public Gasto Update(Gasto entity)
        {
            throw new NotImplementedException();
        }
    }
}
