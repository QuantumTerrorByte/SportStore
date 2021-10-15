using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class AdminIndexViewModel
    {
        public Product[] Products { get; set; }
        public int LastEditedId { get; set; }
    }
}