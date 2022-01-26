using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Core;
using DAO.DataTransferModel;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.ProductModel;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public static readonly SyncObj ProductsSyncObj = new();
        private readonly AppDataContext _appDataContext;

        public ProductRepository(AppDataContext appDataContext)
            => _appDataContext = appDataContext;

        public async Task<Product> GetProduct(long id, bool includeInners = false)
            => await Products(includeInners).FirstOrDefaultAsync(p => p.Id == id);

        IQueryable<Product> Products(bool includeInners = false)
        {
            return includeInners
                ? _appDataContext.Products
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DescriptionsLi)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.DopDescriptions)
                    .Include(p => p.ProductInfos).ThenInclude(i => i.Table)
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl)
                : _appDataContext.Products
                    .Include(p => p.NavCategoryFirstLvl)
                    .Include(p => p.NavCategorySecondLvl);
        }

        public List<Product> GetProductsById(params long[] ids)
        {
            return ids != null && ids.Any()
                ? _appDataContext.Products.Where(p => ids.Contains(p.Id)).ToList()
                : throw new ArgumentException("no ids params or null");
        }

        public async Task<List<Product>> GetProductsByIdAsync(params long[] ids)
        {
            return ids != null && ids.Any()
                ? await _appDataContext.Products.Where(p => ids.Contains(p.Id)).ToListAsync()
                : throw new ArgumentException("no ids params or null");
        }

        public async Task<List<Product>> GetAllProductsListAsync(bool includeInners = false) //todo check db query
            => await Products(includeInners).ToListAsync();

        /// <summary>
        /// Check contains all ids in DB
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> CheckContainsAsync(long[] ids)
        {
            return ids != null && ids.Length == await _appDataContext.Products
                .Select(p => p.Id).Where(id => ids.Contains(id)).CountAsync();
        }

        public (IList<Product>, int)
            GetFilteredProducts(FilteredProductsRepoRequestModel requestModel) //todo lang
        {
            var products = Products(requestModel.AttachInfo)
                .Where(p =>
                    (requestModel.Category1 == null ||
                     p.NavCategoryFirstLvl.ValueEn == requestModel.Category1) &&
                    (p.PriceUsd >= requestModel.MinPrice && p.PriceUsd <= requestModel.MaxPrice) &&
                    (requestModel.Brand == null || p.Brand == requestModel.Brand));

            products = requestModel.Sort switch
            {
                "increasingPrice" => products.OrderBy(p => p.PriceUsd),
                "descendingPrice" => products.OrderByDescending(p => p.PriceUsd),
                _ => products,
            };
            var totalItems = products.Count();
            products = products.Skip(requestModel.PageSize * (requestModel.Page - 1))
                .Take(requestModel.PageSize);
            return (products.ToList(), totalItems);
        }

        public void AddOrEditProduct(Product product)
        {
            if (product.Id != 0)
            {
                Product currentProduct = _appDataContext.Products.FirstOrDefault(p => p.Id == product.Id);
                if (currentProduct != null)
                {
                    currentProduct.Id = product.Id;
                    currentProduct.Name = product.Name;
                    currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                    currentProduct.NavCategoryFirstLvl = product.NavCategoryFirstLvl;
                }
            }

            _appDataContext.Products.Add(product);
            _appDataContext.SaveChanges();
        }

        public Product RemoveProduct(int id)
        {
            Product product = _appDataContext.Products.First(p => p.Id == id);
            _appDataContext.Remove(product);
            _appDataContext.SaveChanges();
            return product;
        }


        public ProductInfo GetProductInfo(long prodId, Langs lang = Langs.US)
        {
            return _appDataContext.ProductInfos
                .Where(pI => pI.ProductId == prodId)
                .Include(pI => pI.DescriptionsLi)
                .Include(pI => pI.ShortDescription)
                .Include(pI => pI.DopDescriptions)
                .Include(pI => pI.Table)
                .FirstOrDefault(i => i.Lang == lang);
        }

        public ProductInfo RemoveProductInfo(long id)
        {
            ProductInfo info = _appDataContext.ProductInfos.Find(id);
            _appDataContext.Remove(info);
            _appDataContext.SaveChanges();
            return info;
        }

        public IQueryable<ProductLine> GetLines()
            => _appDataContext.ProductLines.Include(l => l.Product);

        public IList<string> GetBrands()
            => _appDataContext.Products.Select(p => p.Brand).Distinct().ToList();

        public IEnumerable<Category> GetCategories(int lvl = 0)
        {
            return lvl switch
            {
                1 => GetRawCategories(1).ToHashSet(),
                2 => GetRawCategories(2).ToHashSet(),
                _ => _appDataContext.Categories,
            };
        }

        IQueryable<Category> GetRawCategories(int lvl = 0)
        {
            return lvl == 1 ? _appDataContext.Products
                    .Select(p => p.NavCategoryFirstLvl)
                : lvl == 2 ? _appDataContext.Products
                    .Select(p => p.NavCategorySecondLvl)
                : _appDataContext.Categories;
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

        public async Task SaveChangesAsync()
        {
            await _appDataContext.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _appDataContext.SaveChanges();
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