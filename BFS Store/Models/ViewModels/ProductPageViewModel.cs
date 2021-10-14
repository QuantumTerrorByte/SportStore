using SportStore.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class ProductPageViewModel
    {
        public ProductPageViewModel(long id, string name, string imgUrl, string categoryFirstLvl, string categorySecondLvl, string brand, decimal priceUsd, long popularity, ProductInfo info, string returnUrl)
        {
            Id = id;
            Name = name;
            ImgUrl = imgUrl;
            CategoryFirstLvl = categoryFirstLvl;
            CategorySecondLvl = categorySecondLvl;
            Brand = brand;
            PriceUSD = priceUsd;
            Popularity = popularity;
            Info = info;
            ReturnUrl = returnUrl;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string CategoryFirstLvl { get; set; }

        public string CategorySecondLvl { get; set; }

        public string Brand { get; set; }

        public decimal PriceUSD { get; set; }

        public long Popularity { get; set; }

        public ProductInfo Info { get; set; }

        public string ReturnUrl { get; set; }

        public ProductPageViewModel()
        {
        }
    }
}