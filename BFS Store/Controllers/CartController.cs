using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SportStore.Deprecated;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository Repository { get; }

        private Cart Cart { get; set; }

        public CartController(IProductRepository repository, Cart cartService)
        {
            Repository = repository;
            Cart = cartService;
        }

        public IActionResult CartPage(string returnUrl)
        {
            return View(new CartIndexViewModel {Cart = this.Cart, ReturnUrl = returnUrl});
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, string returnUrl)
        {
            var product = Repository.GetProducts(true)
                .FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Cart.Add(product, 1);
            }
            return RedirectToAction("CartPage", new {returnUrl});
        }

        [HttpPost]
        public IActionResult Remove(int productId, string returnUrl)
        {
            var product = Repository.GetProducts(true)
                .FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Cart.RemoveLine(product);
            }
            return RedirectToAction("CartPage", new {returnUrl});
        }

        // public void Test()
        // {
        //     Console.WriteLine((Cart as SessionCart).Session.Equals(HttpContext.Session));
        // }
    }
}