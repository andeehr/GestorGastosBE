using GestorGastosBE.Entities;
using System.Collections.Generic;

namespace GestorGatosBE.Common.Services.Interfaces
{
    public interface IGastoService
    {
        IEnumerable<Gasto> GetAll();
        Gasto GetById(int id);
        Gasto Add(Gasto entity);
        Gasto Update(Gasto entity, Gasto dbEntity);
        void Remove(Gasto entity);
    }
}
