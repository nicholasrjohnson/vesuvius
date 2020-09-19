using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Vesuvius.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HighScoreController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HighScoreController> _logger;

        public HighScoreController(ILogger<HighScoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Score  Get( string owner )
        {
            //return the score from the database that belongs to the owner
            return new Score( 0, "Nick");
        }

        [HttpPut]
        public void Put( Score s ) {
            //put the score in the dataase
        }
    }
}
