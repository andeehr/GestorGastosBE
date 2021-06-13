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
        public IEnumerable<CategoriaGasto> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("Get/{id:int}")]
        public CategoriaGasto GetById(int Id)
        {
            return _repository.GetById(Id);
        }
    }
}
