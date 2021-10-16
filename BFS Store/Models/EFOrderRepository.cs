using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportStore.Models.Interfaces;

namespace SportStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private readonly IProductPageDbContext _productPageDbContext;

        public EFOrderRepository(IProductPageDbContext productPageDbContext)
        {
            this._productPageDbContext = productPageDbContext;
        }

        public IQueryable<Order> GetOrders => _productPageDbContext.Orders
            .Include(o => o.CartLines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            _productPageDbContext.AttachRange(order.CartLines.Select(l => l.Product));
            if (order.Id == 0)
            {
                _productPageDbContext.Orders.Add(order);
            }

            _productPageDbContext.SaveChanges();
        }
    }
}