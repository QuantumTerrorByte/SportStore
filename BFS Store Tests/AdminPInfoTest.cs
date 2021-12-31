using System.Collections.Generic;
using DAO;
using DAO.Models;
using DAO.Models.ProductModel;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace SportStoreTests
{
    public class AdminPInfoTest
    {
        [Fact]
        public void RouterTest()
        {
            Mock<AppDataContext> repo = new Mock<AppDataContext>();
            repo.Setup(r => r.Products).Returns(Reppo.Products as DbSet<Product>);
            var temp = repo.Object.Products.AsQueryable();
            
        }
    }

    class Reppo
    {
        public static IEnumerable<Product> Products { get; set; } = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "p1",
                Amount = 3,
                Brand = "Brand",
                ProductInfos = new List<ProductInfo>()
                {
                    new ProductInfo()
                    {
                        Id = 1, Lang = Langs.RU,
                        ProductId = 1,
                    },
                    new ProductInfo()
                    {
                        Id = 2, Lang = Langs.UA,
                        ProductId = 1,
                    },
                    new ProductInfo()
                    {
                        Id = 3, Lang = Langs.US,
                        ProductId = 1,
                    }
                }
            },
            new Product()
            {
                Id = 2,
                Name = "p2",

                Amount = 3,
                Brand = "Brand",
                ProductInfos = new List<ProductInfo>()
                {
                    new ProductInfo()
                    {
                        Id = 4, Lang = Langs.RU,
                        ProductId = 2,
                    },
                    new ProductInfo()
                    {
                        Id = 5, Lang = Langs.UA,
                        ProductId = 2,
                    },
                    new ProductInfo()
                    {
                        Id = 6, Lang = Langs.US,
                        ProductId = 2,
                    }
                }
            },
            new Product()
            {
                Id = 3,
                Name = "p3",

                Amount = 3,
                Brand = "Brand",
                ProductInfos = new List<ProductInfo>()
                {
                    new ProductInfo()
                    {
                        Id = 7, Lang = Langs.RU,
                        ProductId = 3,
                    },
                    new ProductInfo()
                    {
                        Id = 8, Lang = Langs.UA,
                        ProductId = 3,
                    },
                    new ProductInfo()
                    {
                        Id = 9, Lang = Langs.US,
                        ProductId = 3,
                    }
                }
            },
        };


        public Reppo()
        {
        }
    }
}