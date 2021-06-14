using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Entities
{
    public class Gasto : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Medio")]
        public int IdMedio { get; set; }
        public Medio Medio { get; set; }

        [ForeignKey("SubcategoriaGasto")]
        public int IdSubcategoria { get; set; }
        public SubcategoriaGasto SubcategoriaGasto { get; set; }
    }
}
