using DAO.Models.ProductModel;

namespace DAO.Models.Core
{
    public class CartLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}