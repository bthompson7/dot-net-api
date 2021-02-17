using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {



        [HttpGet]
        public IEnumerable<Values> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Values
            {
                Name = "Hello, World this is my new REST API! Written in C#!",
                CurrentTime = (int)DateTimeOffset.Now.ToUnixTimeSeconds()
            })
            .ToArray();
        }



    }
}
