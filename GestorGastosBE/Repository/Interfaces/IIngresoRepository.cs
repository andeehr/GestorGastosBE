using GestorGastosBE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository.Interfaces
{
    public interface IIngresoRepository
    {
        IEnumerable<Ingreso> GetAll();
        Ingreso GetById(int id);
        Ingreso Insert(Ingreso entity);
        Ingreso Update(Ingreso entity);
        void Delete(int? id);
    }
}
