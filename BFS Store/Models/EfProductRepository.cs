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
        private readonly DataContext _dataContext;

        public EfProductRepository(DataContext dataContext)
            => _dataContext = dataContext;


        IQueryable<Product> Products(bool includeInners = false)
        {
            return includeInners
                ? _dataContext.Products
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DescriptionsLi)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DopDescriptions)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.Table)
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl)
                : _dataContext.Products
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
                Product currentProduct = _dataContext.Products.FirstOrDefault(p => p.Id == product.Id);
                if (currentProduct != null)
                {
                    currentProduct.Id = product.Id;
                    currentProduct.Name = product.Name;
                    currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                    currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                }
            }

            _dataContext.Products.Add(product);
            _dataContext.SaveChanges();
        }

        public Product RemoveProduct(int id)
        {
            Product product = _dataContext.Products.First(p => p.Id == id);
            _dataContext.Remove(product);
            _dataContext.SaveChanges();
            return product;
        }


        public IEnumerable<Category> GetCategories(int lvl = 0)
        {
            return lvl == 1
                ? _dataContext.Products.Select(p => p.NavCategoryFirstLvlId).ToArray().Select(i => _dataContext.Category.Find(i)).ToArray()
                : lvl == 2
                    ? _dataContext.Products.Select(p => p.NavCategorySecondLvlId).ToArray().Select(i => _dataContext.Category.Find(i))
                        .ToArray()
                    : _dataContext.Category.ToArray();
        }

        public ProductInfo GetProductInfo(long prodId, Lang lang = Lang.US)
        {
            return _dataContext.ProductInfo
                .Include(i => i.DescriptionsLi)
                .Include(i => i.ShortDescription)
                .Include(i => i.DopDescriptions)
                .Include(i => i.Table)
                .Where(i => i.ProductId == prodId)// null?
                .FirstOrDefault(i => i.Lang == lang);
        }

        public ProductInfo RemoveProductInfo(long id)
        {
            ProductInfo info = _dataContext.ProductInfo.Find(id);
            _dataContext.Remove(info);
            _dataContext.SaveChanges();
            return info;
        }

        public ProductPageViewModel ProductPageViewModels { get; set; }


        public IQueryable<CartLine> GetLines()
            => _dataContext.CartLines.Include(l => l.Product);
    }
}












        // public IEnumerable<ProductInfo> Test(long id)
        // {
        //     return _dataContext.ProductInfo
        //             .Include(i => i.DescriptionsLi)
        //             .Include(i => i.ShortDescription)
        //             .Include(i => i.DopDescriptions)
        //             .Include(i => i.Table)
        //             .Where(i => i.ProductId == id).ToArray();
        // }
