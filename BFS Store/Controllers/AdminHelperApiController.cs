using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;

namespace SportStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminHelperApiController : ControllerBase
    {
        private IProductRepository ProductRepository { get; }

        public AdminHelperApiController(IProductRepository productRepository) => ProductRepository = productRepository;

        [HttpGet]
        public string Test(int id)
        {
            return "Hello " + id;
        }

        [HttpGet("{id:int}", Name = "IfAbsentProdInfoChecker")]
        public string IfAbsentProdInfoChecker(int id, Lang lang)
        {
            var result = $"value id = {id}: Lang = {lang}";
            Console.WriteLine(result);
            return result;
        }


        [HttpGet]
        public Dictionary<string, string> Get([FromBody] TestModel arg)
        {
            Console.WriteLine(arg + " get");
            return new Dictionary<string, string>() {{"name", arg.Name}};
        }

        // GET: api/Reff2/5

        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        // return "value";
        // }

        // POST: api/Reff2
        [HttpPost]
        public string Post([FromBody] string value)
        {
            Console.WriteLine(value + "post");
            return value + "was taked";
        }

        // PUT: api/Reff2/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Reff2/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class TestModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}