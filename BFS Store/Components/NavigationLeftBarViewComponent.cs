using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Components
{
    public class NavigationLeftBarViewComponent : ViewComponent
    {
        private IProductRepository Repository { get; set; }

        public NavigationLeftBarViewComponent(IProductRepository repository)
        {
            Repository = repository;
            
        }

        public IViewComponentResult Invoke()
        {
            var categories = Repository.GetProducts()
                .Select(p=>p.Category)
                .Distinct();
            var currentCategory = RouteData?.Values["category"]; 
            return View(new LeftBarViewModel{Categories = categories, CurrentCategory = currentCategory?.ToString()});
        }
    }
}