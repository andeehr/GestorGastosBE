using AutoMapper;
using GestorGastosBE.Api.Controllers;
using GestorGastosBE.Api.Models.Gasto;
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
    public class GastoController : ApiController
    {
        private readonly IGastoService service;

        public GastoController(IGastoService service, IWebHostEnvironment environment, ILogger<GastoController> logger, IMapper mapper)
            : base(environment, logger, mapper)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Gasto>> GetAll()
        {
            var result = service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<GastoModel> GetById(int id)
        {
            var entity = service.GetById(id);
            if (entity != null)
            {
                return Mapper.Map<GastoModel>(entity);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Gasto> Add([FromBody] GastoModel model)
        {
            var entity = Mapper.Map<Gasto>(model);
            var result = service.Add(entity);
            return Created(entity.Id, Mapper.Map<GastoModel>(result));
        }

        [HttpPut]
        public ActionResult<Gasto> Update([FromBody] GastoModel model)
        {
            var entity = Mapper.Map<Gasto>(model);
            var dbEntity = service.GetById(model.Id);
            if (dbEntity != null)
            {
                var result = service.Update(entity, dbEntity);
                return Created(entity.Id, Mapper.Map<GastoModel>(result));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult<Gasto> Remove(int id)
        {
            var entity = service.GetById(id);

            if (entity != null)
            {
                service.Remove(entity);
                return Ok();
            }
            return NotFound();
        }
    }
}
