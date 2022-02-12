using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using DAO.Models.DataTransferModel;

namespace DAO.Interfaces
{
    public interface IOrderRepository: IRepositoryBase<Order>
    {
        public static readonly object OrdersSyncObj  = new object();
        Task<List<Order>> GetOrdersAsync();
        Task<OrderIndexViewModel> GetOrdersPageAsync(int pageSize,int currentPage);
    }
}