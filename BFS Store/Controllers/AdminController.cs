using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Deprecated;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository _productRepository;

        public AdminController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult ControlPanel()
        {
            return View(_productRepository.GetProducts(false).Take(2));
        }
        
        [HttpGet]
        public IActionResult CreateProduct(int count)
        {
            Product[] form = new Product[count];
            for (int i = 0; i < count; i++)
            {
                form[i] = new Product();
            }

            return View(new AdminCreateViewModel {BlocksCount = count, Products = form});
        }
        
        [HttpPost]
        public IActionResult CreateProduct(AdminCreateViewModel adminModel)
        {
            if (ModelState.IsValid)
            {
                foreach (Product product in adminModel.Products)
                {
                    _productRepository.AddProduct(product);
                }

                return RedirectToAction("ControlPanel", "Admin");
            }
            else
            {
                return View("CreateProduct", adminModel);
            }
        }

        public IActionResult Edit(int id)
        {
            if (id == -1)
            {
                return View(_productRepository.GetProducts(true).ToArray());
            }

            Product product = _productRepository.GetProducts(true).FirstOrDefault(p => p.Id == id);
            return View(new Product[] {product});
        }

        [HttpPost]
        public IActionResult Edit(Product[] products)
        {
            if (ModelState.IsValid)
            {
                _productRepository.EditProducts(products);
                return RedirectToAction("ControlPanel");
            }
            else
            {
                return View(products);
            }
        }

        public IActionResult Delete(int id)
        {
            _productRepository.RemoveProduct(id);
            return RedirectToAction("ControlPanel");
        }
    }
}