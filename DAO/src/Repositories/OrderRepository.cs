using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Task<List<Order>> GetOrders => _dataContext.Orders
            .Include(o => o.Cart)
            .ThenInclude(c => c.CartLines)
            .ThenInclude(cl=>cl.Product).ToListAsync();

        public void SaveOrder(Order order)
        {
        }
    }
}