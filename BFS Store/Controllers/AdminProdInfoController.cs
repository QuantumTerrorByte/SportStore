using System;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class AdminProdInfoController : Controller //todo return urls
    {
        private IProductRepository ProductRepository { get; }

        public AdminProdInfoController(IProductRepository productRepository)
            => ProductRepository = productRepository;


        [HttpGet]
        public RedirectToActionResult ProdInfoRouter(int productId, Lang lang)
        {
            ProductInfo info = ProductRepository.GetProductInfo(productId, lang);
            if (info != null) // if (answer)
            {
                var product = ProductRepository.GetProduct(productId);
                ViewBag.Product = product;
                ViewBag.Info = info;
                return RedirectToAction("EditInfo", "AdminProdInfo", new {arg1 = 1, arg2 = "two", arg3 = true, id = 10, info = info, arg4 = product});
            }

            return RedirectToAction("CreateInfo", "AdminProdInfo", (productId, lang));
        }

        [HttpGet]
        public IActionResult CreateInfo(int productId, Lang lang)
        {
            //todo
            var product = ProductRepository.GetProduct(productId);
            if (product == null)
            {
                return RedirectToAction("ControlPanel", "Admin", productId);
            }

            var info = new ProductInfo {ProductId = productId};
            product?.ProductInfos?.Add(info); //
            return RedirectToAction("EditInfo", "AdminProdInfo", (product, info));
        }


        public IActionResult EditInfo(int arg1, string arg2, bool arg3, int id, ProductInfo info, Product arg4) //todo mapper
        {
            var product = new Product();
            // var info = new ProductInfo();
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

        [HttpPost]
        public IActionResult EditInfo(Product product)
        {
            ProductRepository.AddEditProduct(product);
            return RedirectToAction("ControlPanel", "Admin", product.Id);
        }


        [HttpPost]
        public IActionResult DeleteInfo(int pId, Lang lang)
        {
            try
            {
                var testInfo = ProductRepository.Test(pId);
                var infoId = ProductRepository.GetProductInfo(pId, lang).Id;
                var deleted = ProductRepository.RemoveProductInfo(infoId);
                return RedirectToAction("ControlPanel", "Admin", pId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("ControlPanel", "Admin", pId);
            }
        }
    }
}