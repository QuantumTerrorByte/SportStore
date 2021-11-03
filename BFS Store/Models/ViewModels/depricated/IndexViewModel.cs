using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public string CurrentCategory { get; set; }
    }
}