using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;

namespace SportStore.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;

        public EfProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


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
                changingItem.PriceUsd = modifiedProduct.PriceUsd;
            }

            _dataContext.SaveChanges();
        }

        public void RemoveProduct(int id)
        {
            Product product = _dataContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _dataContext.Remove(product);
                _dataContext.SaveChanges();
            }
        }

        public IQueryable<CartLine> GetLines()
        {
            return _dataContext.CartLines.Include(l => l.Product);
        }


        public IEnumerable<Product> Products(bool includeInners = false)
            => includeInners
                ? _dataContext.Products
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DescriptionsLi)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DopDescriptions)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.Table)
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl).ToArray()
                : _dataContext.Products
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl).ToArray();

        public IEnumerable<Category> GetCategories(int lvl = 0)
            => lvl == 1
                ? _dataContext.Products.Select(p => p.NavCategoryFirstLvl).Distinct().ToArray()
                : lvl == 2
                    ? _dataContext.Products.Select(p => p.NavCategorySecondLvl).Distinct().ToArray()
                    : _dataContext.Category.ToArray();

        public IEnumerable<Category> GetCategoriesTest(int lvl = 0)
            => lvl == 1
                ? _dataContext.Products.Select(p=>p.NavCategoryFirstLvlId).ToArray().Select(i=>_dataContext.Category.Find(i)).ToArray()
                : lvl == 2
                    ? _dataContext.Products.Select(p=>p.NavCategorySecondLvlId).ToArray().Select(i=>_dataContext.Category.Find(i)).ToArray()
                    : _dataContext.Category.ToArray();

        public IEnumerable<string> GetCategoriesByLang(int lvl, Lang lang = Lang.ENG)
        {
            return lvl is 1 or 2
                ? lang switch
                {
                    Lang.RU => GetCategories(lvl).Select(c => c.ValueRu).ToArray(),
                    Lang.ENG => GetCategories(lvl).Select(c => c.ValueEn).ToArray(),
                    Lang.UKR => GetCategories(lvl).Select(c => c.ValueUk).ToArray(),
                }
                : throw new ArgumentException("Method arg lvl can take only 1 or 2");
        }
    }
}