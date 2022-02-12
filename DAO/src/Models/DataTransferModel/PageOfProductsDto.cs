using System.Collections.Generic;
using DAO.Models.ProductModel;

namespace DAO.Models.DataTransferModel
{
    public class PageOfProductsDto
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Product> Products { get; set; }
    }

    public class ProductForOrderAddModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}