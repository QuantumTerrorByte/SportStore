using System.Linq;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders { get; }
        void SaveOrder(Order order);
    }
}