using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Org.BouncyCastle.Crypto.Engines;
using SportStore.Controllers;
using SportStore.Models;
using SportStore.Models.ViewModels;
using Xunit;

namespace SportStoreTests
{
    public class ProductControllerTest
    {
        [Fact]
        public void CanPaginate()
        {
            Mock<IProductRepository> repoMock = new Mock<IProductRepository>();
            repoMock.Setup(r => r.GetProducts()).Returns(new Product[]
            {
                new Product {Id = 1, Name = "P1"},
                new Product {Id = 2, Name = "P2"},
                new Product {Id = 3, Name = "P3"},
                new Product {Id = 4, Name = "P4"},
                new Product {Id = 5, Name = "P5"},
            }.AsQueryable);
            ProductController controller = new ProductController(repoMock.Object);
            controller.PageSize = 2;
            var result = (controller.Index(null, 2) as ViewResult)?
                .Model as ProductsListViewModel;
            var arrResult = result?.Products.ToArray();
            Assert.True(arrResult?.Length == 2);
            Assert.Equal(3, arrResult[0].Id);
            Assert.Equal(4, arrResult[1].Id);
        }

        [Fact]
        public void CanCategorise()
        {
            Mock<IProductRepository> repo = new Mock<IProductRepository>();
            repo.Setup(r => r.GetProducts()).Returns(
                new Product[]
                {
                    new Product {Name = "p1", Category = "none"},
                    new Product {Name = "p2", Category = "third"},
                    new Product {Name = "p3", Category = "first"},
                    new Product {Name = "p4", Category = "second"},
                    new Product {Name = "p5", Category = "first"},
                }.AsQueryable
            );
            ProductController productController = new ProductController(repo.Object);
            var resultForCategory = (productController.Index("first") as ViewResult)?.Model as ProductsListViewModel;
            Assert.True(resultForCategory.Category == "first");
            var result = resultForCategory.Products.ToArray();
            Assert.True(result.Length==2);
            Assert.True(result[0].Category =="first"&&result[0].Name=="p3");
            Assert.True(result[1].Category =="first"&&result[1].Name=="p5");
        }
    }
}