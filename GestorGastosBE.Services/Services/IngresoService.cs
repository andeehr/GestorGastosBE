using GestorGastosBE.Entities;
using GestorGastosBE.Repository.Interfaces;
using GestorGatosBE.Common.Data.Interfaces;
using GestorGatosBE.Common.Services.Interfaces;
using System.Collections.Generic;

namespace GestorGastosBE.Services.Services
{
    public class IngresoService : IIngresoService
    {
        private readonly IUnitOfWork unitOfWork;

        public IngresoService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private IGenericRepository<Ingreso> Repository => unitOfWork.IngresoRepository;

        public Ingreso Add(Ingreso entity)
        {
            var result = Repository.Add(entity);
            unitOfWork.Commit();

            return result;
        }

        public IEnumerable<Ingreso> GetAll()
        {
            return Repository.GetAll();
        }

        public Ingreso GetById(int id)
        {
            return Repository.FindSingleBy(x => x.Id == id, x => x.Medio, x => x.CategoriaIngreso);
        }

        public void Remove(Ingreso entity)
        {
            Repository.Remove(entity);
            unitOfWork.Commit();
        }

        public Ingreso Update(Ingreso entity, Ingreso dbEntity)
        {
            dbEntity.Fecha = entity.Fecha;
            dbEntity.IdMedio = entity.IdMedio;
            dbEntity.IdCategoriaIngreso = entity.IdCategoriaIngreso;
            dbEntity.Importe = entity.Importe;
            dbEntity.Observaciones = entity.Observaciones;

            unitOfWork.Commit();

            return dbEntity;
        }
    }
}
