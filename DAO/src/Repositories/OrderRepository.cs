using System.Linq;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public IQueryable<Order> GetOrders => _dataContext.Orders
            .Include(o => o.CartLines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            _dataContext.AttachRange(order.CartLines.Select(l => l.Product));
            if (order.Id == 0)
            {
                _dataContext.Orders.Add(order);
            }

            _dataContext.SaveChanges();
        }
    }
}