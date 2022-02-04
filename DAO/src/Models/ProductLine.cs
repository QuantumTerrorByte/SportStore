using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class ProductLine
    {
        public long Id { get; set; }
        public long CartId { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long Amount { get; set; }
        // public string Img { get; set; } todo
    }
}