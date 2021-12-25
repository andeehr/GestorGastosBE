using AutoMapper;
using GestorGastosBE.Api.Models.Gasto;
using GestorGastosBE.Entities;

namespace GestorGastosBE.Api.Config.Automapper
{
    public class GastoProfile : Profile
    {
        public GastoProfile()
        {
            CreateMap<Gasto, GastoModel>();
            CreateMap<GastoModel, Gasto>();
        }
    }
}
