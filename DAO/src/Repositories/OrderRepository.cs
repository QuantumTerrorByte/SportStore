using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Core;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.DataTransferModel;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public static readonly SyncObj OrdersSyncObj = new();
        private readonly AppDataContext _appDataContext;

        public OrderRepository(AppDataContext appDataContext) : base(appDataContext)
        {
            _appDataContext = appDataContext;
        }

        private IQueryable<Order> GetOrders(bool withInclude = true)
        {
            return _appDataContext.Orders
                .Include(o => o.Costumer)
                .ThenInclude(c => c.Address)
                .Include(o => o.Cart)
                .ThenInclude(c => c.CartLines)
                .ThenInclude(cl => cl.Product);
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await GetOrders().ToListAsync();
        }

        public async Task<OrderIndexViewModel> GetOrdersPageAsync(int pageSize, int currentPage)
        {
            if (pageSize < 1 && currentPage < 1)
                throw new Exception($"pageSize:{pageSize}, currentPage:{currentPage}");

            var orders = await GetOrders()
                .Skip(pageSize * (currentPage - 1))
                .Take(pageSize).ToListAsync();
            
            var summaryOrders = await GetOrders().CountAsync();

            return new OrderIndexViewModel
            {
                Orders = orders,
                PagingInfo = new PagingInfo(summaryOrders,
                    pageSize, currentPage)
            };
        }
    }
}