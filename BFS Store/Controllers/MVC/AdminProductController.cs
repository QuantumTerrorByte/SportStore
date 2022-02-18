using System;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models.ProductModel;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers.MVC
{
    public class AdminProductController : Controller //todo view on admin top panel
    {
        private IProductRepository ProductRepository { get; }

        public AdminProductController(IProductRepository productRepository)
            => ProductRepository = productRepository;

        // [Authorize]
        public async Task<IActionResult> ControlPanel(int lastEditId)
        {
            ViewBag.LastEditId = lastEditId;
            var temp = await ProductRepository.GetAllProductsListAsync();
            return View(temp.Take(20).ToArray());
            // return null;
        }

        [HttpPost]
        public async Task<IActionResult> AddProducts(ProductLineViewModel[] productLines)
        {
            return null;
        }
        
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            ProductRepository.AddOrEditProduct(product);
            return RedirectToAction("ControlPanel", "AdminProduct");
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.AddOrEditProduct(product);

            return RedirectToAction("ControlPanel", "AdminProduct", product.Id);
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