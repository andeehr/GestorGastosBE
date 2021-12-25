using GestorGastosBE.Entities;
using System.Collections.Generic;

namespace GestorGatosBE.Common.Services.Interfaces
{
    public interface ICategoriaGastoService
    {
        IEnumerable<CategoriaGasto> GetAll();
        CategoriaGasto GetById(int id);
    }
}
