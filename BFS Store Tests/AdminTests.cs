using System.Linq;
using Moq;
using SportStore.Controllers;
using SportStore.Models;
using Xunit;

namespace SportStoreTests
{
    public class AdminTests
    {
        [Fact]
        public void Can_Create()
        {
            Mock<IProductRepository> mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(r => r.GetProducts()).Returns(new Product[]
            {
                new Product
                {
                    Id = 1, Name = "P1"
                },
                new Product
                {
                    Id = 2, Name = "P2"
                },
                new Product
                {
                    Id = 3, Name = "P3"
                },
            }.AsQueryable);

            AdminController target = new AdminController(mockRepo.Object);
            
            
            
        }
    }
}