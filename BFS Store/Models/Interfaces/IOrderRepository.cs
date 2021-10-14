using System.Linq;

namespace SportStore.Models.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders { get; }
        void SaveOrder(Order order);
    }
}