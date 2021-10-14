using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportStore.Models;
using SportStore.Models.ProductModel;

namespace SportStore.Deprecated
{
    public class EFProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;

        public EFProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public void AddProduct(Product product)
        {
            _dataContext.Products.Add(product);
            _dataContext.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            Product currentProduct = _dataContext.Products.FirstOrDefault(p => p.Id == product.Id);
            if (currentProduct != null)
            {
                currentProduct.Id = product.Id;
                currentProduct.Name = product.Name;
                currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                // currentProduct.Description = product.Description;
                currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
            }

            _dataContext.SaveChanges();
        }

        public void EditProducts(Product[] products)
        {
            Dictionary<long, Product> idDictionary = products.ToDictionary(p => p.Id);
            var changingItems = _dataContext.Products.Where(p => idDictionary.Keys.Contains(p.Id));
            foreach (Product changingItem in changingItems)
            {
                Product modifiedProduct = idDictionary[changingItem.Id];
                changingItem.Name = modifiedProduct.Name;
                changingItem.NavCategoryFirstLvl = modifiedProduct.NavCategoryFirstLvl;
                // changingItem.Description = modifiedProduct.Description;
                changingItem.PriceUSD = modifiedProduct.PriceUSD;
            }

            _dataContext.SaveChanges();
        }

        public void RemoveProduct(int id)
        {
            Product product = _dataContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _dataContext.Remove(product);
            }

            _dataContext.SaveChanges();
        }

        public IQueryable<Product> Products(bool includeInners)
            => includeInners
                ? _dataContext.Products
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.ShortDescription)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DescriptionsLi)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DopDescriptions)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.Table)
                : _dataContext.Products;


        public IQueryable<CartLine> GetLines()
        {
            return _dataContext.CartLines.Include(l => l.Product);
        }

   

        public IQueryable<Product> GetProducts(bool includeInners)
            => includeInners
                ? _dataContext.Products
                    .Include(p => p.ProductInfos)
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl)
                : _dataContext.Products;

        public IQueryable<Category> GetCategories(int lvl)
            => lvl == 1
                ? _dataContext.Products.Select(p => p.NavCategoryFirstLvl)
                : lvl == 2
                    ? _dataContext.Products.Select(p => p.NavCategorySecondLvl)
                    : throw new ArgumentException("Method arg lvl can take only 1 or 2");

        public IEnumerable<string> GetCategoriesByLang(int lvl, Lang lang = Lang.ENG)
            => lvl is 1 or 2
                ? lang switch
                {
                    Lang.RU => GetCategories(lvl).Select(c => c.ValueRu) as IEnumerable<string>,
                    Lang.ENG => GetCategories(lvl).Select(c => c.ValueEn) as IEnumerable<string>,
                    Lang.UKR => GetCategories(lvl).Select(c => c.ValueUk) as IEnumerable<string>,
                }
                : throw new ArgumentException("Method arg lvl can take only 1 or 2");
    }
}