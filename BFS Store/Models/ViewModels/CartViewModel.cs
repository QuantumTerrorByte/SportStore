using System.Collections.Generic;

namespace SportStore.Models.ViewModels
{
    public class CartViewModel
    {
        public List<ProductLineViewModel> Lines { get; set; }
    }

    public class ProductLineViewModel
    {
        public long ProductId { get; set; }
        public int Quantity { get; set; }
    }
}