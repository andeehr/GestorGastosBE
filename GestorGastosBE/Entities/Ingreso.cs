using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Entities
{
    public class Ingreso : BaseEntity
    {
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Medio")]
        [Required]
        public int IdMedio { get; set; }
        public Medio Medio { get; set; }

        [ForeignKey("CategoriaIngreso")]
        [Required]
        public int IdCategoriaIngreso { get; set; }
        public CategoriaIngreso CategoriaIngreso { get; set; }
    }
}
