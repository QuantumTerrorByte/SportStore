using DAO.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class ProductPageViewModel
    {
        public ProductPageViewModel()
        {
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public Category CategoryFirstLvl { get; set; }

        public Category CategorySecondLvl { get; set; }

        public string Brand { get; set; }

        public decimal PriceUSD { get; set; }

        public long Popularity { get; set; }

        public ProductInfo Info { get; set; }

        public string ReturnUrl { get; set; }
        
        public int Amount { get; set; }
    }
}