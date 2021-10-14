using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class AdminCreateViewModel
    {
        public Product[] Products { get; set; }
        public int BlocksCount { get; set; }
    }
}