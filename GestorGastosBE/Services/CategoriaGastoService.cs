using GestorGastosBE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Services
{
    public class CategoriaGastoService
    {
        private readonly GGContext _context;

        public CategoriaGastoService(GGContext context)
        {
            _context = context;
        }
    }
}
