using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        public static int createCount;
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
            createCount++;
            Console.WriteLine(createCount);
        }

        public IActionResult Index()
        {
            return View(_repository.GetProducts());
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _repository.AddProduct(product);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}