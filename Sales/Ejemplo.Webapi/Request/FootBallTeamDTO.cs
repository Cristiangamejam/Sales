using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.Webapi.Dtos
{
    public class FootBallTeamDTO
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public string Manager { get; set; }
        public int Id { get; internal set; }

    }
}
