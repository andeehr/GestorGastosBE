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
    public class GastoController :ControllerBase
    {
        private readonly IGastoRepository _repository;

        public GastoController(IGastoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Gasto> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("Get/{id:int}")]
        public Gasto GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        [HttpPost("Add")]
        public Gasto Add([FromBody] Gasto entity)
        {
            return _repository.Insert(entity);
        }

        [HttpPost("Update")]
        public Gasto Update([FromBody] Gasto entity)
        {
            return _repository.Update(entity);
        }

        [HttpPost("Delete/{id:int}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
