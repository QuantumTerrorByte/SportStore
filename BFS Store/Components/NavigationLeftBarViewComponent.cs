using DAO.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            var categories = Repository.LangGetCategories(1);
            var currentCategory = RouteData?.Values["category"];
            return null;
            // return View(new LeftBarViewModel
            // {
            //     Categories = categories, 
            //     CurrentCategory = currentCategory?.ToString(),
            // });
        }
    }
}