using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart _cart;
        private IOrderRepository _orderRepository;

        public OrderController(Cart cart, IOrderRepository orderRepository)
        {
            _cart = cart;
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public ViewResult CheckOut()
            => View(new Order());

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            if (_cart.Lines().Count() == 0) //combine with front button block
            {
                ModelState.AddModelError("", "Cart is empty");
            }

            if (ModelState.IsValid)
            {
                order.CartLines = _cart.Lines().ToArray();
                _orderRepository.SaveOrder(order);
                return RedirectToAction("Completed");
            }
            else
            {
                return View(order);
            }
        }

        public IActionResult Completed()
        {
            _cart.Clear();
            return View(_orderRepository.GetOrders);
        }

        public IActionResult OrdersList()
            => View(_orderRepository.GetOrders.OrderBy(o => o.IsDone));

        public IActionResult MarkingDone(int orderId)
        {
            Order targetOrder = _orderRepository.GetOrders.FirstOrDefault(o => o.Id == orderId);
            if (targetOrder != null)
            {
                targetOrder.IsDone = true;
                _orderRepository.SaveOrder(targetOrder);
            }
            return RedirectToAction("OrdersList");
        }
    }
}