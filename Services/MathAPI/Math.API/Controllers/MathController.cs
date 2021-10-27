using MathAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        public IMathService MathService { get; set; }
        public MathController(IMathService mathService)
        {
            MathService = mathService;
        }

        [HttpGet("{Number}")]
        public Boolean GetIsPrime(int number)
        {
            return MathService.GetIsPrime(number);
        }

    }
}
