using AutoMapper;
using GestorGastosBE.Api.Models.Ingreso;
using GestorGastosBE.Entities;

namespace GestorGastosBE.Api.Config.Automapper
{
    public class IngresoProfile : Profile
    {
        public IngresoProfile()
        {
            CreateMap<IngresoModel, Ingreso>();
            CreateMap<Ingreso, IngresoModel>();

        }
    }
}
