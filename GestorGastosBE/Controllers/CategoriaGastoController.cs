using GestorGastosBE.Entities;
using GestorGastosBE.Repository;
using GestorGastosBE.Repository.Interfaces;
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
        private readonly IRepository<CategoriaGasto> _repository;

        public CategoriaGastoController(IRepository<CategoriaGasto> repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAll")]
        public ActionResult Get()
        {
            var result = _repository.GetAll();
            return Ok(result);
        }


        [HttpGet("Get/{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _repository.GetById(id);
            if (result == null) {
                return NotFound("La categoria no existe");
            }
            return Ok(result);
        }
    }
}
