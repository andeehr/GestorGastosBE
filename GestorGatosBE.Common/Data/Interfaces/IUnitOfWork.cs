using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;

namespace GestorGatosBE.Common.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<CategoriaGasto> CategoriaGastoRepository { get; }
        IGenericRepository<Gasto> GastoRepository { get; }
        IGenericRepository<Ingreso> IngresoRepository { get; }
        void Commit();
    }
}
