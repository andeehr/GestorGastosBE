using GestorGastosBE.Api.Models.Medio;
using GestorGastosBE.Api.Models.SubcategoriaGasto;
using System;

namespace GestorGastosBE.Api.Models.Gasto
{
    public class GastoModel : BaseModel
    {
        public DateTime? Fecha { get; set; }
        public decimal? Importe { get; set; }
        public string Observaciones { get; set; }
        public int IdMedio { get; set; }
        public int IdSubcategoria { get; set; }
        public MedioModel Medio { get; set; }
        public SubcategoriaGastoModel SubcategoriaGasto { get; set; }
    }
}
