using DAO.Models;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
            => View();
    }
}