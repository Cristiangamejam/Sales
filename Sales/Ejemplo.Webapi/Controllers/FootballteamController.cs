using ejemplo.Application;
using ejemplo.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballteamController : ControllerBase
    {
        IApplication<Footballteam> _footbal;
        public FootballteamController(IApplication<Footballteam> footbal)
        {
            _footbal = footbal;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok( new Footballteam() { 
                Name = "Unión",
                Score = 100,
            });
        }
    }
}
