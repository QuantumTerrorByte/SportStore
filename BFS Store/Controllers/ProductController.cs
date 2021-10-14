using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Deprecated;
using SportStore.Models;
using SportStore.Models.Interfaces;
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
                Products = _repository.GetProducts(true)
                    .Where(p => (category == null || p.NavCategoryFirstLvl.ValueEn == category) && (p.PriceUSD >= minPrice &&
                        p.PriceUSD <= maxPrice))
                    .OrderBy(p => p.Id)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = _repository
                        .GetProducts(true)
                        .Count(p => category == null || p.NavCategoryFirstLvl.ValueEn == category)
                },
                CurrentCategory = category
            });
        }

        [HttpGet]
        public IActionResult ProductPage(int productId, string returnUrl)
        {
            var lang = "en-US";
            var product = _repository.Products(true).FirstOrDefault(p => p.Id == productId);
            if (product == null)
                return RedirectToAction(returnUrl);


            return View(new ProductPageViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                ImgUrl = product.ImgUrl,
                PriceUSD = product.PriceUSD,
                CategoryFirstLvl = product.GetCategoryByLang(1),
                CategorySecondLvl = product.GetCategoryByLang(2),
                Info = product.GetInfoByLang(),
                ReturnUrl = returnUrl,
            });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}