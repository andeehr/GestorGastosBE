using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Entities
{
    public class SubcategoriaGasto : BaseEntity
    {
        public string Descripcion { get; set; }

        [ForeignKey("CategoriaGasto")]
        public int IdCategoria { get; set; }
        public CategoriaGasto CategoriaGasto { get; set; }
    }
}
