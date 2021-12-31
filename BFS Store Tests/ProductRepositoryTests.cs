using System.Linq;
using System.Threading.Tasks;
using DAO;
using DAO.Models.ProductModel;
using DAO.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace SportStoreTests
{
    public class ProductRepositoryTests
    {
        private static AppDataContext _dataContext;

        public ProductRepositoryTests()
        {
            _dataContext = new AppDataContext(new DbContextOptionsBuilder<AppDataContext>()
                .UseInMemoryDatabase("ProductsTest").Options);
            _dataContext.Database.EnsureDeleted();
            _dataContext.Database.EnsureCreated();
            Seed();
        }

        private static void Seed()
        {
            _dataContext.Products.AddRange(
                new Product {Id = 1, Amount = 10, Name = "First"},
                new Product {Id = 2, Amount = 20, Name = "Second"},
                new Product {Id = 3, Amount = 30, Name = "Third"},
                new Product {Id = 4, Amount = 40, Name = "Fourth"},
                new Product {Id = 5, Amount = 40, Name = "Fifth"}
            );
            _dataContext.SaveChanges();
        }

        [Fact]
        public async Task Test()
        {
            var repo = new ProductRepository(_dataContext);
            var result = await repo.GetProductsByIdAsync(new long[] {1, 2, 3});
            var first = await _dataContext.Products.FirstOrDefaultAsync();
            Assert.Equal("First", first.Name);
            Assert.Equal(3, result.Count());
        }
    }
}