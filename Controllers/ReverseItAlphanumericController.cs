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
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericServices _reverseItAlphanumericServices;

        public ReverseItAlphanumericController(ReverseItAlphanumericServices reverseItAlphanumericServices)
        {
            _reverseItAlphanumericServices = reverseItAlphanumericServices;
        }
    }
}