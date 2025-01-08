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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }
    }
}