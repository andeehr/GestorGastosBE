using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestorGastosBE.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
        public readonly IWebHostEnvironment Environment;
        public ILogger Logger { get; }
        public IMapper Mapper { get; }

        public ApiController(IWebHostEnvironment environment, ILogger logger, IMapper mapper)
        {
            Environment = environment;
            Logger = logger;
            Mapper = mapper;
        }
        protected CreatedAtRouteResult Created<TModel>(long id, TModel model)
        {
            return CreatedAtRoute(new { id }, model);
        }
    }
}