using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class AdminProductInfoController : Controller //todo return urls
    {
        private IProductRepository RepositoryProduct { get; }

        public AdminProductInfoController(IProductRepository repositoryProduct)
            => RepositoryProduct = repositoryProduct;


        [HttpGet]
        public Dictionary<string, string> IsExistInfo(int productId, Lang lang)
        {
            var productInfo = RepositoryProduct.GetProductInfo(productId, lang);
            var answer = productInfo == null ? "false" : "true";
            
            return new Dictionary<string, string>
            {
                {"isExist", answer},
                {"url", $"/AdminProductInfo/EditInfo?productId={productId}&lang={lang}"},
            };
        }


        [HttpGet]
        public IActionResult EditInfo(int productId, Lang lang) //todo mapper
        {
            var product = new Product();
            var info = new ProductInfo();
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
            RepositoryProduct.AddEditProduct(product);
            return RedirectToAction("ControlPanel", "AdminMain", product.Id);
        }


        [HttpPost]
        public IActionResult DeleteInfo(int productId, Lang lang)
        {
            try
            {
                var infoId = RepositoryProduct.GetProductInfo(productId, lang).Id;
                var deleted = RepositoryProduct.RemoveProductInfo(infoId);
                return RedirectToAction("ControlPanel", "AdminMain", productId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("ControlPanel", "AdminMain", productId);
            }
        }
    }
}