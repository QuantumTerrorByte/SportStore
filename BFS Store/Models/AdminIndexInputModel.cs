using SportStore.Models.ProductModel;

namespace SportStore.Models
{
    public class AdminIndexInputModel
    {
        public Product[] Products { get; set; }
        public int LastEditedId { get; set; }
    }
}