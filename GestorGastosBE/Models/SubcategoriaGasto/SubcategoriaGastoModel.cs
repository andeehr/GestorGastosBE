using GestorGastosBE.Api.Models.Categoria;

namespace GestorGastosBE.Api.Models.SubcategoriaGasto
{
    public class SubcategoriaGastoModel
    {
        public string Descripcion { get; set; }
        public CategoriaModel CategoriaGasto { get; set; }
    }
}
