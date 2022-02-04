using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;
using DAO.Models;
using DAO.Models.ProductModel;
using DAO.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SportStore.Controllers;
using SportStore.Controllers.API;
using Xunit;
using Assert = Xunit.Assert;

namespace SportStoreTests
{
    public class OrderRepositoryTest
    {
        private static AppDataContext _dataContext;

        public OrderRepositoryTest()
        {
            _dataContext = new AppDataContext(new DbContextOptionsBuilder<AppDataContext>()
                .UseInMemoryDatabase("Orders").Options);
            _dataContext.Database.EnsureDeleted();
            _dataContext.Database.EnsureCreated();
            Seed();
        }

        private static void Seed()
        {
            _dataContext.Products.AddRange(
                new Product {Id = 1, Amount = 10, Name = "First"},
                new Product {Id = 2, Amount = 20, Name = "Second"},
                new Product {Id = 3, Amount = 30, Name = "Third"}
            );
            _dataContext.Orders.Add(new Order()
            {
                Id = 1,
                Cart = new Cart()
                {
                    Id = 1,
                    CartLines = new List<ProductLine>()
                    {
                        new ProductLine() {ProductId = 1, Amount = 5},
                        new ProductLine() {ProductId = 2, Amount = 5},
                    },
                },
                OrderStatus = Statusess.New
            });
            _dataContext.SaveChanges();
        }


        [Fact]
        public async Task Check_ids_contains()
        {
            var orderRepository = new OrderRepository(_dataContext);
            var order = new Order
            {
                DateTime = DateTime.Now,
                Comment = "asdasd",
                Cart = new Cart {CartLines = new List<ProductLine> {new() {Amount = 10}}}
            };
            await orderRepository.AddAsync(order);
            var orderFromDb = await orderRepository.GetFirstAsync();
            Assert.Equal(order, orderFromDb);
        }

        [Fact]
        public async Task Can_Approve_And_Create_Delayed_Orders()
        {
            var productLines = new ProductLine[]
            {
                new ProductLine {ProductId = 1, Amount = 15},
                new ProductLine {ProductId = 2, Amount = 15},
                new ProductLine {ProductId = 3, Amount = 30},
            };
            var orderController = new OrderController(new OrderRepository(_dataContext),
                new ProductRepository(_dataContext),
                new AppUsersRepository(_dataContext));
            Assert.Equal(10, _dataContext.Products.FirstOrDefault(p => p.Id == 1)?.Amount);
            var result = await orderController.SetApproved(1, productLines, "");

            Assert.Equal(0, _dataContext.Products.FirstOrDefault(p => p.Id == 1)?.Amount);
            Assert.Equal(5, _dataContext.Products.FirstOrDefault(p => p.Id == 2)?.Amount);
            Assert.Equal(0, _dataContext.Products.FirstOrDefault(p => p.Id == 3)?.Amount);
            Assert.Equal(2, _dataContext.Orders.Count());
            Assert.Equal(1, _dataContext.Orders.FirstOrDefault(o => o.OrderStatus == Statusess.Delayed)
                .Cart.CartLines.Count());
            Assert.NotNull(_dataContext.Orders.FirstOrDefault(o => o.OrderStatus == Statusess.Delayed)
                ?.Cart.CartLines.FirstOrDefault(l => l.Amount == 5 && l.ProductId == 1));
        }

        [Fact]
        public async Task Can_Return_Products_From_NotPickedUp()
        {
            var orderController = new OrderController(new OrderRepository(_dataContext),
                new ProductRepository(_dataContext),
                new AppUsersRepository(_dataContext));
            
            Assert.Equal(10, _dataContext.Products.Find(1).Amount);
            Assert.Equal(20, _dataContext.Products.Find(2).Amount);
            Assert.Equal(Statusess.New, _dataContext.Orders.Find(1).OrderStatus);
            
            var result = await orderController.NotPickedUp(1);

            Assert.Equal(5, _dataContext.Products.Find(1).Amount);
            Assert.Equal(15, _dataContext.Products.Find(2).Amount);
            Assert.Equal(Statusess.NotPickedUp, _dataContext.Orders.Find(1).OrderStatus);
        }
    }
}