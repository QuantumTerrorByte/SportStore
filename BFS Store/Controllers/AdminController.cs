using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class AdminController : Controller //todo view on admin top panel
    {
        private IProductRepository ProductRepository { get; }

        public AdminController(IProductRepository productRepository)
            => ProductRepository = productRepository;


        public IActionResult ControlPanel(int lastEditId)
        {
            ViewBag.LastEditId = lastEditId;
            return View(ProductRepository.GetProducts().OrderBy(p => p.Name).Take(10).ToArray());
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

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                ProductRepository.RemoveProduct(id);
                return RedirectToAction("ControlPanel");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("ControlPanel");
            }
        }


        
    }
}