using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.ProductModel;
using DAO.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers.API
{
    // hybrid controller
    public class OrderController : Controller
    {
        private static object _syncObj = new();
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IAppUsersRepository _usersRepository;
        private readonly ILogger _logger;

        public OrderController(
            IOrderRepository orderRepository,
            IProductRepository productRepository,
            IAppUsersRepository usersRepository,
            ILogger logger)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _usersRepository = usersRepository;
            _logger = logger;
        }

        [HttpGet]
        public ViewResult CheckOut()
        {
            return View(new Order());
        }

        [HttpGet]
        public async Task<ViewResult> Index(string error)
        {
            ViewBag.Error = error;
            var orders = await _orderRepository.GetOrdersAsync();
            return View(orders);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderViewModel orderViewModel)
        {
            if (orderViewModel.CartLines.Count < 1) return BadRequest("No lines");
            var lines = new List<ProductLine>();
            var order = new Order {Cart = new Cart {CartLines = lines}};
            foreach (var cartLineViewModel in orderViewModel.CartLines)
            {
                lines.Add(new()
                {
                    ProductId = cartLineViewModel.ProductId,
                    Amount = cartLineViewModel.Amount,
                });
            }

            var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            AppUser user;
            try
            {
                user = userId == null
                    ? new AppUser {Email = orderViewModel.Email}
                    : await _usersRepository.GetAsync(userId);
                if (user == null) throw new Exception();
            }
            catch (Exception e)
            {
                user = new AppUser {Email = orderViewModel.Email};
            }

            user.Phone = orderViewModel.Phone;
            user.FirstName = orderViewModel.FirstName;
            user.SecondName = orderViewModel.SecondName;
            user.Patronymic = orderViewModel.Patronymic;
            user.Address = orderViewModel.Address;
            order.GiftWrap = orderViewModel.GiftWrap;
            order.Comment = orderViewModel.Comment;
            order.DateTime = DateTime.Now;
            order.Costumer = user;

            try
            {
                var result = await _orderRepository.AddAsync(order);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct(long orderId, string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(orderId);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(long productId, int amount, long orderId,
            string returnUrl)
        {
            var order = await _orderRepository.GetAsync(orderId);
            if (order == null)
            {
                ModelState.AddModelError("", "wrong order id");
                return RedirectToAction("Index");
            }

            order.Cart.CartLines.Add(new ProductLine()
            {
                ProductId = productId,
                Amount = amount
            });

            ViewBag.orderId = orderId;
            try
            {
                await _orderRepository.EditAsync(order);
                ViewBag.message = "Done";
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "add to DB error");
            }

            return RedirectToAction(nameof(AddProduct), nameof(Order), returnUrl);
        }

        /// <summary>
        /// Set order status in to approved and remove(reservation) products from store(db)
        /// if need more than in store, creating order with all of we have and create delayable order
        /// with remainder
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="pLines"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [Authorize]
        public async Task<IActionResult> SetApproved(long orderId, ProductLine[] pLines, string returnUrl)
        {
            if (pLines.Length < 1)
            {
                return RedirectToAction("Index", "Order", "Empty order");
            }

            Order currentOrder;
            Order delayedOrder;
            try
            {
                lock (ProductRepository.ProductsSyncObj)
                {
                    lock (OrderRepository.OrdersSyncObj)
                    {
                        currentOrder = _orderRepository.Get(orderId);
                        if (currentOrder == null)
                        {
                            return RedirectToAction("Index", "Order", "Wrong order Id");
                        }

                        var orderProductLinesDictionary = pLines.ToDictionary(l => l.ProductId);
                        var storeOrderProducts =
                            _productRepository.GetProductsById(orderProductLinesDictionary.Keys.ToArray());
                        var delayedOrderLines = new List<ProductLine>();

                        foreach (Product storeProduct in storeOrderProducts)
                        {
                            var requestedProductLine = orderProductLinesDictionary[storeProduct.Id];
                            if (storeProduct.Amount >= requestedProductLine.Amount)
                            {
                                storeProduct.Amount -= requestedProductLine.Amount;
                            }
                            else
                            {
                                delayedOrderLines.Add(new ProductLine
                                {
                                    ProductId = storeProduct.Id,
                                    Amount = requestedProductLine.Amount - storeProduct.Amount
                                });
                                requestedProductLine.Amount -= storeProduct.Amount;
                                storeProduct.Amount = 0;
                            }
                        }

                        currentOrder.OrderStatus = Statusess.Approved;
                        _orderRepository.Edit(currentOrder);
                        _productRepository.SaveChanges();

                        if (delayedOrderLines.Any())
                        {
                            delayedOrder = new Order()
                            {
                                OrderStatus = Statusess.Delayed,
                                Cart = new Cart() {CartLines = delayedOrderLines},
                                CostumerId = currentOrder.CostumerId,
                                DateTime = DateTime.Now,
                                Comment = currentOrder.Comment,
                            };
                            _orderRepository.Add(delayedOrder);
                        }
                    }
                }
            }
            catch (Exception e) //todo command pattern for backup
            {
                return RedirectToAction("Index", "Order", "Problems with data base");
            }
 
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> SetStatus(long orderId, Statusess status, string returnUrl)
        {
            Order order = (await _orderRepository.GetOrdersAsync())
                .FirstOrDefault(o => o.Id == orderId);
            if (order == null)
            {
                ModelState.AddModelError("", "add to DB error");
                return Redirect(returnUrl);
            }

            order.OrderStatus = status;
            return Redirect(returnUrl);
        }
    }
}
