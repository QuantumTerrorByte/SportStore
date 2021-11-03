using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;
using SportStore.Models.DAO;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.ProductModel;
using Xunit;

namespace SportStoreTests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void GetCategoriesTest()
        {
            var data = new Product[]
            {
                new Product {Brand = "targetBrand"},
                new Product {Brand = "targetBrand"},
                new Product {Brand = "first"},
                new Product {Brand = "targetBrand"},
                new Product {Brand = "second"},
                new Product {Brand = "targetBrand"},
                new Product {Brand = "first"},
                new Product {Brand = "second"},
            }.AsQueryable();
            var result = data.Distinct(new ProductComparorImp()).Select(p => p.Brand).ToList();
            Assert.Equal(3, result.Count);
        }
    }
}
// mockRepo.Setup(r => r.GetProducts(false)).Returns(new Product[]
// {
//     new Product
//     {
//         Id = 1, Name = "P1"
//     },
//     new Product
//     {
//         Id = 2, Name = "P2"
//     },
//     new Product
//     {
//         Id = 3, Name = "P3"
//     },
// }.AsQueryable);