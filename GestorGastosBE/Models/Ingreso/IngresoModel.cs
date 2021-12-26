using GestorGastosBE.Api.Models.Categoria;
using GestorGastosBE.Api.Models.Medio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Api.Models.Ingreso
{
    public class IngresoModel : BaseModel
    {
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public int IdMedio { get; set; }
        public MedioModel Medio { get; set; }
        public int IdCategoriaIngreso { get; set; }
        public CategoriaModel CategoriaIngreso { get; set; }
    }
}
