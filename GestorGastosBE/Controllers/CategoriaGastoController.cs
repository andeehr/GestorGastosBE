using GestorGastosBE.Entities;
using GestorGastosBE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaGastoController : ControllerBase
    {
        private readonly GGContext _context;

        public CategoriaGastoController(GGContext context)
        {
            _context = context;
        }

       [HttpGet("GetAll")]
        public IEnumerable<CategoriaGasto> Get()
        {
            return _context.CategoriasGastos.ToArray();
        }

        [HttpGet("GetById/{id:int}")]
        public CategoriaGasto GetById(int Id)
        {
            return _context.CategoriasGastos.FirstOrDefault(x => x.IdCategoria == Id);
        }
    }
}
