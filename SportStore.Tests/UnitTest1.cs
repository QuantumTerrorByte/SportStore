using System;
using SportStore.Models.ViewModels;
using Xunit;

namespace SportStore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = new PagingInfo {CurrentPage = 2, TotalItems = 100, ItemsPerPage = 10}.ItemsPerPage;
            Assert.True(x == 10);
        }
    
    }
}