using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SportStore.Models.ProductModel
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Amount { get; set; }
        public string Brand { get; set; }
        public decimal PriceUsd { get; set; }
        public string ImgUrl { get; set; }
        public Category NavCategoryFirstLvl { get; set; } 
        public Category NavCategorySecondLvl { get; set; } 
        public decimal Rating { get; set; }
        public long Popularity { get; set; }
        public List<ProductInfo> ProductInfos { get; set; }
        
        public List<LikeJunction> LikeJunction { get; set; }
        public List<Comment> Comments { get; set; }
        
        public ProductInfo GetInfoByLang(Langs langs = Langs.US)
        {
            return ProductInfos.FirstOrDefault(i => i.Lang == langs);
        }
    }
}