using ejemplo.EApplication;
using ejemplo.Entities;
using Ejemplo.Webapi.Dtos;
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
        IEApplication<Footballteam> _footbal;
        public FootballteamController(IEApplication<Footballteam> footbal)
        {
            _footbal = footbal;
        }

        [HttpGet]
        public IActionResult Get( )
        {
            return Ok(_footbal.GetAll());
            //return Ok( new Footballteam() { 
            //    Name = "Unión",
            //    Score = 100,
            //});
        }

        [HttpPost]
        public IActionResult Save(FootBallTeamDTO dto)
        {
            var f = new Footballteam()
            {
                Name = dto.Name,
                Score = dto.Score,
                Manager = dto.Manager,
            };
             _footbal.Save(f);

            return Ok(f);
        }

    }
}
