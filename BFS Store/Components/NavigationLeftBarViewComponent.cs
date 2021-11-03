using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.ProductModel;
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
            var categories = Repository.LangGetCategories(1);
            var currentCategory = RouteData?.Values["category"];
            
            return View(new LeftBarViewModel
            {
                Categories = categories, 
                CurrentCategory = currentCategory?.ToString(),
            });
        }
    }
}