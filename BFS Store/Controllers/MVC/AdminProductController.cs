using System;
using System.Linq;
using DAO.Interfaces;
using DAO.Models.ProductModel;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers.MVC
{
    public class AdminProductMvcController : Controller //todo view on admin top panel
    {
        private IProductRepository ProductRepository { get; }

        public AdminProductMvcController(IProductRepository productRepository)
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
            return RedirectToAction("ControlPanel", "AdminProductMvc");
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.AddEditProduct(product);

            return RedirectToAction("ControlPanel", "AdminProductMvc", product.Id);
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