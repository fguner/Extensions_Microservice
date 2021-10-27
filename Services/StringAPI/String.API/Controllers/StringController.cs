using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StringAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace String.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        public IStringService StringService { get; set; }

        public StringController(IStringService stringService)
        {
            StringService = stringService;
        }

        [HttpGet("{Text}")]
        public int GetTextLenght(string text)
        {
           return StringService.GetLenghtText(text);
        }

    }
}
