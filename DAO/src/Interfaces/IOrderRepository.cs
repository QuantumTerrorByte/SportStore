using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;
using DAO.Models.DataTransferModel;

namespace DAO.Interfaces
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        public static readonly object OrdersSyncObj = new object();
        Order Get(long key, bool withInclude = false);
        Task<List<Order>> GetOrdersAsync();
        Task<OrderIndexDto> GetOrdersPageAsync(int pageSize, int currentPage);
    }
}