using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly IProductPageDbContext _productPageDbContext;

        public EfProductRepository(IProductPageDbContext productPageDbContext)
            => _productPageDbContext = productPageDbContext;


        IQueryable<Product> Products(bool includeInners = false)
        {
            return includeInners
                ? _productPageDbContext.Products
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DescriptionsLi)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DopDescriptions)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.Table)
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl)
                : _productPageDbContext.Products
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl);
        }

        public IEnumerable<Product> GetProducts(bool includeInners = false)
            => Products(includeInners).ToArray();

        public Product GetProduct(int id, bool includeInners = false)
            => Products(includeInners).First(p => p.Id == id);

        public void AddEditProduct(Product product)
        {
            if (product.Id != 0)
            {
                Product currentProduct = _productPageDbContext.Products.FirstOrDefault(p => p.Id == product.Id);
                if (currentProduct != null)
                {
                    currentProduct.Id = product.Id;
                    currentProduct.Name = product.Name;
                    currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                    currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                }
            }

            _productPageDbContext.Products.Add(product);
            _productPageDbContext.SaveChanges();
        }

        public Product RemoveProduct(int id)
        {
            Product product = _productPageDbContext.Products.First(p => p.Id == id);
            _productPageDbContext.Remove(product);
            _productPageDbContext.SaveChanges();
            return product;
        }


        public IEnumerable<Category> GetCategories(int lvl = 0)
        {
            return lvl == 1
                ? _productPageDbContext.Products.Select(p => p.NavCategoryFirstLvlId).ToArray().Select(i => _productPageDbContext.Category.Find(i)).ToArray()
                : lvl == 2
                    ? _productPageDbContext.Products.Select(p => p.NavCategorySecondLvlId).ToArray().Select(i => _productPageDbContext.Category.Find(i))
                        .ToArray()
                    : _productPageDbContext.Category.ToArray();
        }

        public ProductInfo GetProductInfo(long prodId, Lang lang = Lang.US)
        {
            return _productPageDbContext.ProductInfo
                .Include(i => i.DescriptionsLi)
                .Include(i => i.ShortDescription)
                .Include(i => i.DopDescriptions)
                .Include(i => i.Table)
                .Where(i => i.ProductId == prodId)
                .FirstOrDefault(i => i.Lang == lang);
        }

        public ProductInfo RemoveProductInfo(long id)
        {
            ProductInfo info = _productPageDbContext.ProductInfo.Find(id);
            _productPageDbContext.Remove(info);
            _productPageDbContext.SaveChanges();
            return info;
        }

        public IEnumerable<ProductInfo> Test(long id)
        {
            return _productPageDbContext.ProductInfo
                    .Include(i => i.DescriptionsLi)
                    .Include(i => i.ShortDescription)
                    .Include(i => i.DopDescriptions)
                    .Include(i => i.Table)
                    .Where(i => i.ProductId == id).ToArray();
        }

        public IQueryable<CartLine> GetLines()
            => _productPageDbContext.CartLines.Include(l => l.Product);
    }
}