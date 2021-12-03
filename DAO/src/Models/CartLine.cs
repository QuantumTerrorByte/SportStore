using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class CartLine
    {
        public long Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}