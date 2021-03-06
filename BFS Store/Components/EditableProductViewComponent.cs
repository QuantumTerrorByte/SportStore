using System.Collections.Generic;
using System.Linq;
using DAO.Interfaces;
using DAO.Models.ProductModel;
using Microsoft.AspNetCore.Mvc;

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
                CategoriesLvl1 = _repository.GetCategories(1),
                CategoriesLvl2 = _repository.GetCategories(1),
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