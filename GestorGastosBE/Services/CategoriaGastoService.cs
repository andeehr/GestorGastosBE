using GestorGastosBE.Entities;
using GestorGastosBE.Repository;
using GestorGastosBE.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Services
{
    public class CategoriaGastoService : ICategoriaGastoService
    {
        private readonly GGContext _context;

        public CategoriaGastoService(GGContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoriaGasto> Get()
        {
            return _context.CategoriasGastos.ToArray();
        }

        public CategoriaGasto GetById(int Id)
        {
            return _context.CategoriasGastos.FirstOrDefault(x => x.IdCategoria == Id);
        }
    }
}
