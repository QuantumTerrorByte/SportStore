using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
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
            });
            ProductController controller = new ProductController(repoMock.Object);
            controller.PageSize = 2;
            var result = (controller.Index(2) as ViewResult)?
                .Model as ProductsListViewModel;
            var arrResult = result?.Products.ToArray();
            Assert.True(arrResult?.Length == 2);
            Assert.Equal(3, arrResult[0].Id);
            Assert.Equal(4, arrResult[1].Id);
        }
    }
}