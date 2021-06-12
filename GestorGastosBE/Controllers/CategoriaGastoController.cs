using GestorGastosBE.Entities;
using GestorGastosBE.Repository;
using GestorGastosBE.Services;
using GestorGastosBE.Services.Interfaces;
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
        private readonly ICategoriaGastoService _service;

        public CategoriaGastoController(ICategoriaGastoService service)
        {
            _service = service;
        }

       [HttpGet("GetAll")]
        public IEnumerable<CategoriaGasto> Get()
        {
            return _service.Get();
        }

        [HttpGet("GetById/{id:int}")]
        public CategoriaGasto GetById(int Id)
        {
            return _service.GetById(Id);
        }
    }
}
