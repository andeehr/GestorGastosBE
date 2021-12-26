using AutoMapper;
using GestorGastosBE.Api.Models.Categoria;
using GestorGastosBE.Api.Models.SubcategoriaGasto;
using GestorGastosBE.Entities;

namespace GestorGastosBE.Api.Config.Automapper
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CategoriaGasto, CategoriaModel>();
            CreateMap<CategoriaIngreso, CategoriaModel>();
            CreateMap<SubcategoriaGasto, SubcategoriaGastoModel>();
        }
    }
}
