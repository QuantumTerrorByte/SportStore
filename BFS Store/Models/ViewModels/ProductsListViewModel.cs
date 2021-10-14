using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}