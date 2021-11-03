using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.Core;

namespace SportStore.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly Cart _cart;

        public HeaderViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
            => View(_cart);
    }
}