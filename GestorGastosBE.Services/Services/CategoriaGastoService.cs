using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using GestorGatosBE.Common.Data.Interfaces;
using GestorGatosBE.Common.Services.Interfaces;
using System.Collections.Generic;

namespace GestorGastosBE.Services.Services
{
    public class CategoriaGastoService : ICategoriaGastoService
    {
        private readonly IUnitOfWork unitOfWork;

        public CategoriaGastoService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private IGenericRepository<CategoriaGasto> Repository => unitOfWork.CategoriaGastoRepository;

        public IEnumerable<CategoriaGasto> GetAll()
        {
            return Repository.GetAll();
        }

        public CategoriaGasto GetById(int id)
        {
            return Repository.FindSingleBy(x => x.Id == id);
        }
    }
}
