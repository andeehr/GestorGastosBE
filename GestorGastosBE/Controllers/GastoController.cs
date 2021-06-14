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
    }
}
