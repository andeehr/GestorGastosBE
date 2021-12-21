using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Entities
{
    public class CategoriaGasto : BaseEntity
    {
        public string Descripcion { get; set; }
    }
}
