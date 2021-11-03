using System.Collections.Generic;
using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class FilteredProductsViewModel
    {
        public IEnumerable<Product> ProductsList { get; set; }
        public List<int> Pagination { get; set; }
    }
}