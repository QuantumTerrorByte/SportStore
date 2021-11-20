using SportStore.Models.ProductModel;

namespace SportStore.Models.Core
{
    public class CartLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}