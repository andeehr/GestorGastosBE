using GestorGastosBE.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Entities
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
