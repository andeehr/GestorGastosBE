using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using GestorGatosBE.Common.Data.Interfaces;
using GestorGatosBE.Common.Services.Interfaces;
using System.Collections.Generic;

namespace GestorGastosBE.Services.Services
{
    public class GastoService : IGastoService
    {
        private readonly IUnitOfWork unitOfWork;

        public GastoService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private IGenericRepository<Gasto> Repository => unitOfWork.GastoRepository;

        public Gasto Add(Gasto entity)
        {
            var result = Repository.Add(entity);
            unitOfWork.Commit();

            return result;
        }

        public IEnumerable<Gasto> GetAll()
        {
            return Repository.GetAll();
        }

        public Gasto GetById(int id)
        {
            return Repository.FindSingleBy(x => x.Id == id, x => x.Medio, x => x.SubcategoriaGasto);
        }

        public void Remove(Gasto entity)
        {
            Repository.Remove(entity);
            unitOfWork.Commit();
        }

        public Gasto Update(Gasto entity, Gasto dbEntity)
        {
            dbEntity.Fecha = entity.Fecha;
            dbEntity.IdMedio = entity.IdMedio;
            dbEntity.IdSubcategoria = entity.IdSubcategoria;
            dbEntity.Importe = entity.Importe;
            dbEntity.Observaciones = entity.Observaciones;

            unitOfWork.Commit();

            return dbEntity;
        }
    }
}
