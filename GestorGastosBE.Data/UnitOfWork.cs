using GestorGastosBE.Entities;
using GestorGastosBE.Repositories;
using GestorGastosBE.Repository.Interfaces;
using GestorGatosBE.Common.Data.Interfaces;

namespace GestorGastosBE.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GGContext context;

        public UnitOfWork(GGContext context)
        {
            this.context = context;
        }

        private IGenericRepository<CategoriaGasto> categoriaGastoRepository;
        public IGenericRepository<CategoriaGasto> CategoriaGastoRepository => categoriaGastoRepository ??= new GenericRepository<CategoriaGasto>(context);

        private IGenericRepository<Gasto> gastoRepository;
        public IGenericRepository<Gasto> GastoRepository => gastoRepository ??= new GenericRepository<Gasto>(context);

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
