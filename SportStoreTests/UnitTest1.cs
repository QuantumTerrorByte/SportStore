using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportStore.Controllers;
using SportStore.Models;
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
            });
            ProductController controller = new ProductController(repoMock.Object);
            controller.PageSize = 2;
            var result = ((controller.Index(2) as ViewResult)?
                .Model as IEnumerable<Product>)?.ToArray();
            Assert.True(result.Length==2);
            Assert.Equal("P3",result[3].Name);
            Assert.Equal("P4",result[4].Name);
        }
    }
}