using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository Repository { get; set; }

        public ProductController(IProductRepository repository)
            => this.Repository = repository;

        public int PageSize { get; set; } = 12;

        [HttpGet]
        public IActionResult Index(string category, int productPage = 1, int minPrice = 0, int maxPrice = int.MaxValue)
        {
            var result = Repository.GetProducts()
                .Where(p => (category == null || p.NavCategoryFirstLvl.ValueEn == category) && (p.PriceUsd >= minPrice &&
                    p.PriceUsd <= maxPrice))
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize).ToArray();

            return View(new ProductsListViewModel
            {
                Products = result,

                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = result.Count(p => category == null || p.NavCategoryFirstLvl.ValueEn == category)
                },
                CurrentCategory = category
            });
        }

        [HttpGet]
        public IActionResult ProductPage(int productId, string returnUrl) //todo lang & admin log
        {
            var lang = Lang.US;
            var product = Repository.GetProduct(productId);
            var info = Repository.GetProductInfo(productId, lang);
            if (product == null)
                return RedirectToAction(returnUrl);
            if (info == null)
                return RedirectToAction(returnUrl);

            return View(new ProductPageViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                ImgUrl = product.ImgUrl,
                PriceUSD = product.PriceUsd,
                CategoryFirstLvl = product.NavCategoryFirstLvl,
                CategorySecondLvl = product.NavCategorySecondLvl,
                Info = info,
            });
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}