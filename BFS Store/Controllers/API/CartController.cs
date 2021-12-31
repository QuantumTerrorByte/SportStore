using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models.ViewModels.depricated;

namespace SportStore.Controllers.API
{
    public class CartController : Controller
    {
        private IProductRepository Repository { get; }
        
        public CartController(IProductRepository repository)
        {
            Repository = repository;
        }

        public IActionResult CartPage(string returnUrl)
        {
            return View(new CartIndexViewModel {ReturnUrl = returnUrl});
        }
                       
     
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, string returnUrl)
        {
            var product = (await Repository.GetAllProductsList()).FirstOrDefault(p => p.Id == productId);
            return RedirectToAction("CartPage", new {returnUrl});
        }

        [HttpPost]
        public IActionResult Remove(int productId, string returnUrl)
        {
            return RedirectToAction("CartPage", new {returnUrl});
        }
        
    }
}