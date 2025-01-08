using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.MC_FiveToSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.MC_FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("")]
    }
}