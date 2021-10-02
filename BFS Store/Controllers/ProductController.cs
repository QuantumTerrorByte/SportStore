using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        public int PageSize { get; set; } = 12;

        public ProductController(IProductRepository repository)
            => this._repository = repository;

        [HttpGet]
        public IActionResult Index(string category, int productPage = 1, int minPrice = 0, int maxPrice = int.MaxValue)
        {
            return View(new ProductsListViewModel
            {
                Products = _repository.GetProducts()
                    .Where(p => (category == null || p.Category == category) && (p.Price >= minPrice &&
                                p.Price <= maxPrice))
                    .OrderBy(p => p.Id)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = _repository
                        .GetProducts()
                        .Count(p => category == null || p.Category == category)
                },
                Category = category
            });
        }

        [HttpGet]
        public IActionResult ProductPage(int productId, string returnUrl)
        {
            var product = _repository.GetProducts().FirstOrDefault(p => p.Id == productId);
            if (product==null)
            {
                return RedirectToAction(returnUrl);
                
            }
            return View(new ProductPageViewModel
            {
                Product = product,
                ReturnUrl = returnUrl,
            });
        }
        // [HttpPost]
        // public RedirectToActionResult Index(int minPrice, int maxPrice)
        // {
        //     Console.WriteLine("from post "+minPrice+"  "+maxPrice);
        //     return RedirectToAction("Index");
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}