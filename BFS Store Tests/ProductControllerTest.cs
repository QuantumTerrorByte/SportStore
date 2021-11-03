using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Org.BouncyCastle.Crypto.Engines;
using SportStore.Controllers;
using SportStore.Infrastructure;
using SportStore.Models;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.ProductModel;
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
            repoMock.Setup(r => r.GetProducts(false)).Returns(new Product[]
            {
                new Product {Id = 1, Name = "P1"},
                new Product {Id = 2, Name = "P2"},
                new Product {Id = 3, Name = "P3"},
                new Product {Id = 4, Name = "P4"},
                new Product {Id = 5, Name = "P5"},
            }.AsQueryable);
            ProductController controller = new ProductController(repoMock.Object);
            controller.PageSize = 2;
            var result = (controller.Index() as ViewResult)?
                .Model as IndexViewModel;
            var arrResult = result?.Products.ToArray();
            Assert.True(arrResult?.Length == 2);
            Assert.Equal(3, arrResult[0].Id);
            Assert.Equal(4, arrResult[1].Id);
        }

        [Fact]
        public void CanCategorise()
        {
            Mock<IProductRepository> repo = new Mock<IProductRepository>();
        }

        [Fact]
        public void CanPagination()
        {
            var result1 = Paginator.GetPagesModel(150, 10, 7);
            Assert.Equal(9, result1.Count);
            Assert.Equal(new List<int> {1, 4, 5, 6, 7, 8, 9, 10, 15}, result1);

            var result2 = Paginator.GetPagesModel(150, 10, 13);
            Assert.Equal(9, result2.Count);
            Assert.Equal(new List<int> {1, 8, 9, 10, 11, 12, 13, 14, 15}, result2);

            var result3 = Paginator.GetPagesModel(10, 3, 2);
            Assert.Equal(4, result3.Count);
            Assert.Equal(new List<int> {1, 2, 3, 4}, result3);
        }
    }
}