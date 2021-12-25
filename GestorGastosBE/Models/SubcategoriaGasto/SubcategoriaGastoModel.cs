using GestorGastosBE.Api.Models.CategoriaGasto;

namespace GestorGastosBE.Api.Models.SubcategoriaGasto
{
    public class SubcategoriaGastoModel
    {
        public string Descripcion { get; set; }
        public CategoriaGastoModel CategoriaGasto { get; set; }
    }
}
