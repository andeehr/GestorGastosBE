using GestorGastosBE.Entities;
using System.Collections.Generic;

namespace GestorGatosBE.Common.Services.Interfaces
{
    public interface IIngresoService
    {
        IEnumerable<Ingreso> GetAll();
        Ingreso GetById(int id);
        Ingreso Add(Ingreso entity);
        Ingreso Update(Ingreso entity, Ingreso dbEntity);
        void Remove(Ingreso entity);
    }
}
