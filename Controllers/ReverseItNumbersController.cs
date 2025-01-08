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
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumbersServices _reverseItNumbersServices;

        public ReverseItNumbersController(ReverseItNumbersServices reverseItNumbersServices)
        {
            _reverseItNumbersServices = reverseItNumbersServices;
        }

        [HttpGet]
        [Route("ReverseItNumbers/{number}")]
        public List <string> ReverseItNumbers(string number)
        {
           return _reverseItNumbersServices.ReversedItNumbers(number);
        }
    }
}