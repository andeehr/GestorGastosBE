using AutoMapper;
using GestorGastosBE.Api.Models.Ingreso;
using GestorGastosBE.Entities;
using GestorGatosBE.Common.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace GestorGastosBE.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoController : ApiController
    {

        private readonly IIngresoService service;

        public IngresoController(IIngresoService service, IWebHostEnvironment environment, ILogger<IngresoController> logger, IMapper mapper)
            : base(environment, logger, mapper)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ingreso>> GetAll()
        {
            var result = service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<IngresoModel> GetById(int id)
        {
            var entity = service.GetById(id);
            if (entity != null)
            {
                return Mapper.Map<IngresoModel>(entity);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Ingreso> Add([FromBody] IngresoModel model)
        {
            var entity = Mapper.Map<Ingreso>(model);
            var result = service.Add(entity);
            return Created(entity.Id, Mapper.Map<IngresoModel>(result));
        }

        [HttpPut]
        public ActionResult<Ingreso> Update([FromBody] IngresoModel model)
        {
            var entity = Mapper.Map<Ingreso>(model);
            var dbEntity = service.GetById(model.Id);
            if (dbEntity != null)
            {
                var result = service.Update(entity, dbEntity);
                return Created(entity.Id, Mapper.Map<IngresoModel>(result));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult<Ingreso> Remove(int id)
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
