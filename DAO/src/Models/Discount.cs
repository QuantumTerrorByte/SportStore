using System;
using System.Collections.Generic;
using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class Discount
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public List<Product> Products  { get; set; }
        public decimal Price  { get; set; }
    }
}