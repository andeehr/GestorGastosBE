using AutoMapper;
using GestorGastosBE.Api.Models.Medio;
using GestorGastosBE.Entities;

namespace GestorGastosBE.Api.Config.Automapper
{
    public class MedioProfile : Profile
    {
        public MedioProfile()
        {
            CreateMap<Medio, MedioModel>();
        }
    }
}
