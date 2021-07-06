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
    public class IngresoController :ControllerBase
    {
        private readonly IIngresoRepository _repository;

        public IngresoController(IIngresoRepository repository)
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
                return NotFound("El ingreso no existe");
            }
            return Ok(result);
        }

        [HttpPost("Add")]
        public ActionResult Add([FromBody] Ingreso entity)
        {
            try {
                var result = _repository.Insert(entity);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Update")]
        public ActionResult Update([FromBody] Ingreso entity)
        {
            try {
                var result = _repository.Update(entity);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            try {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
