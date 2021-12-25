using AutoMapper;
using GestorGastosBE.Api.Controllers;
using GestorGastosBE.Api.Models.CategoriaGasto;
using GestorGastosBE.Entities;
using GestorGatosBE.Common.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace GestorGastosBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaGastoController : ApiController
    {
        private readonly ICategoriaGastoService service;

        public CategoriaGastoController(ICategoriaGastoService service, IWebHostEnvironment environment, ILogger<CategoriaGastoController> logger, IMapper mapper)
            : base(environment, logger, mapper)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoriaGasto>> GetAll()
        {
            var result = service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoriaGastoModel> GetById(int id)
        {
            var entity = service.GetById(id);
            if (entity != null)
            {
                return Mapper.Map<CategoriaGastoModel>(entity);
            }
            return NotFound();
        }
    }
}
