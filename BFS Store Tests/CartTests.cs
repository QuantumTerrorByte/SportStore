using System.Linq;
using System.Runtime.Intrinsics.X86;
using DAO.Models;
using DAO.Models.Core;
using Moq;
using Org.BouncyCastle.Crypto.Macs;
using SportStore.Models;
using SportStore.Models.Core;
using SportStore.Models.ProductModel;
using Xunit;

namespace SportStoreTests
{
    public class CartTests
    {
        [Fact]
        public void Can_Add_Remove_TotalCost_Clear()
        {
            Product first = new Product {Id = 1, Name = "p1", PriceUsd = 10};
            Product second = new Product {Id = 2, Name = "p2", PriceUsd = 20};
            Product third = new Product {Id = 3, Name = "p3", PriceUsd = 30};
            Cart cart = new Cart();
            cart.Add(first, 2);
            cart.Add(first, 5);
            cart.Add(second, 4);
            cart.Add(third,1); // 7 4 1
            
            cart.RemoveLine(second);
            
            CartLine[] lines = cart.Lines().ToArray();

            Assert.True(lines.Length==2);
            Assert.True(lines[0].Product.Id==first.Id&&lines[0].Count==7);
            Assert.True(lines[1].Product.Id==third.Id&&lines[1].Count==1);
            Assert.True(cart.TotalCost()==100);
            
            cart.Clear();
            Assert.False(cart.Lines().Any());
        }
    }
}