using AutoMapper;
using GestorGastosBE.Api.Models.CategoriaGasto;
using GestorGastosBE.Api.Models.SubcategoriaGasto;
using GestorGastosBE.Entities;

namespace GestorGastosBE.Api.Config.Automapper
{
    public class CategoriaGastoProfile : Profile
    {
        public CategoriaGastoProfile()
        {
            CreateMap<CategoriaGasto, CategoriaGastoModel>();
            CreateMap<SubcategoriaGasto, SubcategoriaGastoModel>();
        }
    }
}
