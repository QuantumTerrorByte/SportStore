using System.Linq;
using Moq;
using SportStore.Controllers;
using SportStore.Controllers.MVC;
using SportStore.Models;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.ProductModel;
using Xunit;

namespace SportStoreTests
{
    public class AdminTests
    {
        [Fact]
        public void Can_Create()
        {
            Mock<IProductRepository> mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(r => r.GetProducts(false)).Returns(new Product[]
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

            AdminProductMvcController target = new AdminProductMvcController(mockRepo.Object);
            
            
            
        }
    }
}