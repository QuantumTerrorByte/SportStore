using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository _productRepository;

        public AdminController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Admin
        public IActionResult ControlPanel()
        {
            return View(_productRepository.GetProducts());
        }


        // GET: Admin/Create
        [HttpGet]
        public IActionResult CreateProduct(int count)
        
            => View(new AdminCreateViewModel() {BlocksCount = count});


        [HttpPost]
        // [ValidateAntiForgeryToken]
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
                return View(adminModel);
            }
        }
        // POST: Admin/Create

        public IActionResult Edit(int id)
        {
            if (id == -1)
            {
                return View(_productRepository.GetProducts().ToArray());
            }

            Product product = _productRepository.GetProducts().FirstOrDefault(p => p.Id == id);
            return View(new Product[] {product});
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
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


        // GET: Admin/Delete/5
        public IActionResult Delete(int id)
        {
            _productRepository.RemoveProduct(id);
            return RedirectToAction("ControlPanel");
        }
    }
}