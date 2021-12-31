using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface IOrderRepository: IRepositoryBase<Order>
    {
        public static readonly object OrdersSyncObj  = new object();
        Task<List<Order>> GetOrdersAsync();
        
    }
}