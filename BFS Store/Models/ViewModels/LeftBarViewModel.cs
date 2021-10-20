using System.Collections.Generic;
using System.Linq;
using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class LeftBarViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public string CurrentCategory { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}