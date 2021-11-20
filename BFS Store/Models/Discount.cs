using System;
using System.Collections.Generic;
using SportStore.Models.ProductModel;

namespace SportStore.Models
{
    public class Discount
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public List<Product> Products  { get; set; }
        public decimal Price  { get; set; }
    }
}