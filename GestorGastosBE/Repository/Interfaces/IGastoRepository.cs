using GestorGastosBE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository.Interfaces
{
    public interface IGastoRepository
    {
        IEnumerable<Gasto> GetAll();
        Gasto GetById(int id);
        Gasto Insert(Gasto entity);
        Gasto Update(Gasto entity);
        void Delete(int? id);
    }
}
