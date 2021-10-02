using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Components
{
    public class EditProductsViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke(params Product[] product)
        {
            return View(product);
        }
    }
}