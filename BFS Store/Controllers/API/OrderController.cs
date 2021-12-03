using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers.API
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public ViewResult CheckOut()
            => View(new Order());


        [HttpPost]
        public async Task<IActionResult> SaveOrder([FromBody] OrderViewModel orderViewModel)
        {
            return Ok();
        }

        
        
        
        
        [Authorize]
        public async Task<IActionResult> OrdersList()
        {
            var orders = await _orderRepository.GetOrders;
            var sortedOrders = orders.OrderBy(o => o.IsDone).ToList();
            return View(sortedOrders);
        }

        [Authorize]
        public async Task<IActionResult> MarkingDone(int orderId)
        {
            Order targetOrder = (await _orderRepository.GetOrders).FirstOrDefault(o => o.Id == orderId);
            if (targetOrder != null)
            {
                targetOrder.IsDone = true;
                _orderRepository.SaveOrder(targetOrder);
            }

            return RedirectToAction("OrdersList");
        }
    }
}