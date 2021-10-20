using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SportStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("{age:int}")]
        public string Method(int age)
        {
            return "Hello " + age + " without arg";
        }

        [HttpGet("{name:},{age:int}")]
        public string Method(string name, int age)
        {
            Console.WriteLine("get");
            return "Hello " + name;
        }
        [HttpPost]
        public string Post([FromBody] TestModel value)
        {
            Console.WriteLine(value);
            return "View()";
        }
    }
}