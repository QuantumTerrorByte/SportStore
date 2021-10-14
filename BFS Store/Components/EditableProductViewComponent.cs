using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Deprecated;
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
                Products = product, 
                Categories = _repository.GetCategoriesByLang(1).Distinct().ToArray()
            });
        }
    }

    public class EditableProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<string> Categories { get; set; }
    }
}