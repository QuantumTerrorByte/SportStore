using SportStore.Models.ProductModel;

namespace SportStore.Models.Core
{
    public class CartLine
    {
        private static int IdCounter= 0;
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}