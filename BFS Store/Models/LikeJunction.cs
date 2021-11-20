using SportStore.Models.Auth;
using SportStore.Models.ProductModel;

namespace SportStore.Models
{
    public class LikeJunction
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}