using GestorGastosBE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Services.Interfaces
{
    public interface ICategoriaGastoService
    {
        public IEnumerable<CategoriaGasto> Get();

        public CategoriaGasto GetById(int Id);
    }
}
