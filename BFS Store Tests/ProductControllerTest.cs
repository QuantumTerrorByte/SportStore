using System.Collections.Generic;
using DAO.Interfaces;
using Moq;
using SportStore.Infrastructure;
using Xunit;

namespace SportStoreTests
{
    public class ProductControllerTest
    {
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