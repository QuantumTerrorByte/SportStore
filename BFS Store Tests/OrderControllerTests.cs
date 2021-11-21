using DAO.Interfaces;
using DAO.Models.Core;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportStore.Controllers;
using SportStore.Models;
using SportStore.Models.Core;
using SportStore.Models.ProductModel;
using Xunit;

namespace SportStoreTests
{
    public class OrderControllerTests
    {
        [Fact]
        public void Cannot_Checkout_Empty_Cart()
        {
            Mock<IOrderRepository> repository = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            OrderController target = new OrderController(cart, repository.Object);
            Order order = new Order();
            var result = target.CheckOut(order) as ViewResult;

            repository.Verify(r => r.SaveOrder(It.IsAny<Order>()), Times.Never);

            Assert.False(result.ViewData.ModelState.IsValid);
            Assert.True(string.IsNullOrEmpty(result.ViewName));
            
            
        }

        [Fact]
        public void Can_Save_Orders()
        {
            Mock<IOrderRepository> repository = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            cart.Add(new Product(),2);
            OrderController target = new OrderController(cart, repository.Object);
            target.CheckOut(new Order());
            
            repository.Verify(r => r.SaveOrder(It.IsAny<Order>()), Times.Once);
        }
    }
}