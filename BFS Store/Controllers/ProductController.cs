using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Infrastructure;
using SportStore.Models;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.DataTransferModel;
using SportStore.Models.RequestModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
            => this._productRepository = productRepository;

        public int PageSize { get; set; } = 16;

        [HttpGet] 
        public IActionResult Index()
        {
            var lang = HttpContext.Session.GetLang();
            return View();
        }

        [HttpGet] 
        public ActionResult Products(ProductsRequestModel requestModel)
        {
            var filteredProductsPage = _productRepository.GetFilteredProducts(
                new FilteredProductsRepoRequestModel()
                {
                    Category1 = requestModel.Category1,
                    Brand = requestModel.Brand,
                    Sort = requestModel.Sort,
                    MaxPrice = requestModel.MaxPrice,
                    MinPrice = requestModel.MinPrice
                }
            );
            return View(new IndexViewModel
            {
                Products = filteredProductsPage.Item1,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = requestModel.Page,
                    ItemsPerPage = PageSize,
                    TotalItems = filteredProductsPage.Item1.Count()
                },
                MinPrice = requestModel.MinPrice,
                MaxPrice = requestModel.MaxPrice,
                CurrentCategory = requestModel.Category1
            });
        }

        [HttpGet] public IActionResult ProductPage(int productId, string returnUrl) //todo lang & admin log
        {
            var lang = Langs.US;
            var product = _productRepository.GetProduct(productId);
            var info = _productRepository.GetProductInfo(productId, lang);
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

    class Test
    {
        public static void testMeth(int one, string two, bool three){}
    }
}