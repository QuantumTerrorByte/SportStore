using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public static readonly object OrdersSyncObj  = new object();
        private readonly AppDataContext _appDataContext;

        public OrderRepository(AppDataContext appDataContext) : base(appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _appDataContext.Orders
                .Include(o=>o.Costumer)
                .ThenInclude(c=>c.Address)
                .Include(o => o.Cart)
                .ThenInclude(c => c.CartLines)
                .ThenInclude(cl => cl.Product).ToListAsync();
        }
    }
}