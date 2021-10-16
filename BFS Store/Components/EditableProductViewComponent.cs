using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;

namespace SportStore.Components
{
    public class EditableProductViewComponent : ViewComponent
    {
        private readonly IProductRepository _repository;

        public EditableProductViewComponent(IProductRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(IEnumerable<Product> product)
        {
            return View(new EditableProductViewModel
            {
                Products = product.ToArray(), 
                CategoriesLvl1 = _repository.GetCategories(1).Distinct().ToArray(),
                CategoriesLvl2 = _repository.GetCategories(2).Distinct().ToArray(),
            });
        }
    }

    public class EditableProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> CategoriesLvl1 { get; set; }
        public IEnumerable<Category> CategoriesLvl2 { get; set; }
    }
}