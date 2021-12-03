using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.DataTransferModel;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.ProductModel;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
            => _dataContext = dataContext;


        public IEnumerable<Product> GetProducts(bool includeInners = false) //todo check db query
            => Products(includeInners).ToArray();

        public (IList<Product>, int) GetFilteredProducts(FilteredProductsRepoRequestModel requestModel) //todo lang
        {
            var products = Products(requestModel.AttachInfo)
                .Where(p =>
                    (requestModel.Category1 == null || p.NavCategoryFirstLvl.ValueEn == requestModel.Category1) &&
                    (p.PriceUsd >= requestModel.MinPrice && p.PriceUsd <= requestModel.MaxPrice) &&
                    (requestModel.Brand == null || p.Brand == requestModel.Brand));

            products = requestModel.Sort switch
            {
                "increasingPrice" => products.OrderBy(p => p.PriceUsd),
                "descendingPrice" => products.OrderByDescending(p => p.PriceUsd),
                _ => products,
            };
            var totalItems = products.Count();
            products = products.Skip(requestModel.PageSize * (requestModel.Page - 1)).Take(requestModel.PageSize);
            return (products.ToList(), totalItems);
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

        public Product RemoveProduct(int id)
        {
            Product product = _dataContext.Products.First(p => p.Id == id);
            _dataContext.Remove(product);
            _dataContext.SaveChanges();
            return product;
        }

        public async Task<Product> GetProduct(long id, bool includeInners = false)
            => await Products(includeInners).FirstOrDefaultAsync(p => p.Id == id);

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


        public ProductInfo GetProductInfo(long prodId, Langs lang = Langs.US)
        {
            return _dataContext.ProductInfos
                .Where(pI => pI.ProductId == prodId)
                .Include(pI => pI.DescriptionsLi)
                .Include(pI => pI.ShortDescription)
                .Include(pI => pI.DopDescriptions)
                .Include(pI => pI.Table)
                .FirstOrDefault(i => i.Lang == lang);
        }

        public ProductInfo RemoveProductInfo(long id)
        {
            ProductInfo info = _dataContext.ProductInfos.Find(id);
            _dataContext.Remove(info);
            _dataContext.SaveChanges();
            return info;
        }

        public IQueryable<CartLine> GetLines()
            => _dataContext.CartLines.Include(l => l.Product);

        public IList<string> GetBrands()
            => _dataContext.Products.Select(p => p.Brand).Distinct().ToList();

        public IEnumerable<Category> GetCategories(int lvl = 0)
        {
            return lvl switch
            {
                1 => GetRawCategories(1).ToHashSet(),
                2 => GetRawCategories(2).ToHashSet(),
                _ => _dataContext.Categories,
            };
        }

        IQueryable<Category> GetRawCategories(int lvl = 0)
        {
            return lvl == 1 ? _dataContext.Products
                    .Select(p => p.NavCategoryFirstLvl)
                : lvl == 2 ? _dataContext.Products
                    .Select(p => p.NavCategorySecondLvl)
                : _dataContext.Categories;
        }

        public IEnumerable<string> LangGetCategories(int categoryLvl, Langs lang = Langs.US)
        {
            var result = GetRawCategories(categoryLvl);
            return lang switch
            {
                Langs.US => result.Select(c => c.ValueEn).ToHashSet(),
                Langs.RU => result.Select(c => c.ValueRu).ToHashSet(),
                Langs.UA => result.Select(c => c.ValueUk).ToHashSet(),
                _ => throw new ArgumentOutOfRangeException(nameof(lang), lang, null)
            };
        }
    }
}


// public IEnumerable<Category> GetCategories(int lvl = 0) //todo omg wtf
// {
//     return lvl == 1 ? _dataContext.Products.Select(p => p.NavCategoryFirstLvl.ValueEn).ToArray()
//             .Select(i => _dataContext.Category.Find(i))
//         : lvl == 2 ? _dataContext.Products.Select(p => p.NavCategorySecondLvlId).ToArray()
//             .Select(i => _dataContext.Category.Find(i))
//         : _dataContext.Category.ToArray();
// }