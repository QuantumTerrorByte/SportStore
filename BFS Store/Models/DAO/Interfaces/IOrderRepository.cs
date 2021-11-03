using System.Linq;

namespace SportStore.Models.DAO.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders { get; }
        void SaveOrder(Order order);
    }
}