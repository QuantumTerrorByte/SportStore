using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetOrders { get; }
        void SaveOrder(Order order);
    }
}