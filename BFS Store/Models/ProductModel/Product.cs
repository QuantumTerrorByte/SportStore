using System.Collections.Generic;

namespace SportStore.Models.ProductModel
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Amount { get; set; }
        public string Brand { get; set; }
        public decimal PriceUSD { get; set; }
        public string ImgUrl { get; set; }

        public Category NavCategoryFirstLvl { get; set; }
        public Category NavCategorySecondLvl { get; set; }
        
        public double Rating { get; set; }
        public long Popularity { get; set; }
        public List<ProductInfo> ProductInfos { get; set; }

        public List<Comment> Comments { get; set; }

        public string GetCategoryByLang(int categoryLvl, Lang lang = Lang.ENG)
        {
            return lang switch
            {
                Lang.RU => categoryLvl == 1 ? NavCategoryFirstLvl.ValueRu : NavCategorySecondLvl.ValueRu,
                Lang.ENG => categoryLvl == 1 ? NavCategoryFirstLvl.ValueEn : NavCategorySecondLvl.ValueEn,
                Lang.UKR => categoryLvl == 1 ? NavCategoryFirstLvl.ValueUk : NavCategorySecondLvl.ValueUk,
            };
        }
        public ProductInfo GetInfoByLang(Lang lang = Lang.ENG)
        {
            return ProductInfos.Find(i => i.Lang == lang);
        }
        
    }
}