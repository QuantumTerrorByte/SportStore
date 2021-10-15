using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository ProductRepository { get; }

        public AdminController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public IActionResult ControlPanel(int lastEditId)
        {
            ViewBag.LastEditId = lastEditId;
            return View(ProductRepository.Products().OrderBy(p => p.Name).Take(50).ToArray());
        }


        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            ProductRepository.AddEditProduct(product);
            
            return RedirectToAction("ControlPanel", "Admin");
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.AddEditProduct(product);

            return RedirectToAction("ControlPanel", "Admin", product.Id);
        }

        public IActionResult Delete(int id)
        {
            ProductRepository.RemoveProduct(id);
            return RedirectToAction("ControlPanel");
        }
    }
}