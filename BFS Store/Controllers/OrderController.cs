using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.ProductModel;
using DAO.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportStore.Models.RequestModel;

namespace SportStore.Controllers
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
            IAppUsersRepository usersRepository
            // ILogger logger
        )
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _usersRepository = usersRepository;
            // _logger = logger;
        }

        [HttpGet]
        public ViewResult CheckOut()
        {
            return View(new Order());
        }

        [HttpGet]
        [Route("Order/Index/{category?}")]
        public async Task<ViewResult> Index(string category, int page = 1, int pageSize = 10, string msg = "")
        {
            ViewBag.Msg = msg;
            var orderDTO = await _orderRepository.GetOrdersPageAsync(pageSize, page);
            return View(orderDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequestModel orderRequestModel)
        {
            if (orderRequestModel.CartLines.Count < 1) return BadRequest("No lines");
            var lines = new List<ProductLine>();
            var order = new Order {Cart = new Cart {CartLines = lines}};
            foreach (var cartLineViewModel in orderRequestModel.CartLines)
            {
                lines.Add(new()
                {
                    ProductId = cartLineViewModel.ProductId,
                    Amount = cartLineViewModel.Quantity,
                });
            }

            var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            AppUser user;
            try
            {
                user = userId == null
                    ? new AppUser {Email = orderRequestModel.Email}
                    : await _usersRepository.GetAsync(userId);
                if (user == null) throw new Exception(); //probably impossible with good auth control
            }
            catch (Exception e)
            {
                user = new AppUser {Email = orderRequestModel.Email};
            }

            //todo add to list of address
            user.Phone = orderRequestModel.Phone;
            user.FirstName = orderRequestModel.FirstName;
            user.SecondName = orderRequestModel.SecondName;
            user.Patronymic = orderRequestModel.Patronymic;
            user.Address = orderRequestModel.Address;
            order.GiftWrap = orderRequestModel.GiftWrap;
            order.Comment = orderRequestModel.Comment;
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


        /// <summary>
        /// Set order status in to approved and remove(reservation) products from store(db)
        /// if need more than in store, creating order with all of we have and create delayable order
        /// with remainder
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="pLines"></param>
        /// <returns></returns>
        [Authorize]
        public async Task<IActionResult> SetApproved(long orderId, ProductLine[] pLines)
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

        /// <summary>
        /// Change order status
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="status"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
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

        public async Task<IActionResult> Cancel(long orderId)
        {
            var order = await _orderRepository.GetAsync(orderId);
            if (order != null)
            {
            }

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Return reserved products from order to repository, change order status to NotPickedUp and
        /// set risc mark to target user 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task<IActionResult> NotPickedUp(long orderId) //todo mark costumer as risc
        {
            try
            {
                var order = await _orderRepository.GetAsync(orderId);
                if (order == null)
                {
                    return RedirectToAction("Index", "Order", "Order was not founded");
                }

                lock (ProductRepository.ProductsSyncObj)
                {
                    var orderCartDictionary = order.Cart.CartLines.ToDictionary(l => l.ProductId);
                    var cartProductsFromRepository =
                        _productRepository.GetProductsById(orderCartDictionary.Keys.ToArray());
                    foreach (var product in cartProductsFromRepository)
                    {
                        var productById = orderCartDictionary[product.Id];
                        product.Amount += productById.Amount;
                    }

                    order.OrderStatus = Statusess.NotPickedUp;
                    _orderRepository.SaveChanges();
                    _productRepository.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Order", "Db problems");
            }

            return RedirectToAction(nameof(Index), "Order", "Done");
        }


        [HttpGet]
        public async Task<IActionResult> AddProduct(long orderId, string returnUrl, int page = 1,
            int pageSize = 30, string msg = "")
        {
            ViewBag.Msg = msg;
            ViewBag.OrderId = orderId;
            ViewBag.ReturnUrl = returnUrl;

            var viewModel = await _productRepository.GetProductPageAsync(page, pageSize);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(long productId, int amount, long orderId, string returnUrl)
        {
            Order order;    
            lock (OrderRepository.OrdersSyncObj)
            {
                try
                {
                    order = _orderRepository.Get(orderId, true);
                    order.Cart.CartLines.Add(new ProductLine()
                    {
                        ProductId = productId,
                        Amount = amount
                    });
                    _orderRepository.SaveChanges();
                }
                catch (Exception e)
                {
                    return RedirectToAction("Index", "Order",
                        new
                        {
                            orderId, returnUrl,
                            msg = $"error occured when trying get order({orderId}) from bd."
                        });
                }
            }

            return RedirectToAction(nameof(AddProduct), nameof(Order),
                new
                {
                    returnUrl, orderId,
                    msg = $"{amount} products(id:{productId}) has been added to order(id:{orderId})."
                });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteOrder(long orderId, string returnUrl)
        {
            try
            {
                var order = await _orderRepository.GetAsync(orderId);
                if (order == null)
                {
                    return RedirectToAction(nameof(Index), "Order",
                        new {msg = "wrong order id"});
                }

                var result = await _orderRepository.DeleteAsync(order);
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index), "Order",
                    new
                    {
                        msg = "db problems"
                    });
            }

            return Redirect(returnUrl.Contains("&&msg=") //todo with format
                ? $"{returnUrl}  order id:{orderId} has been deleted"
                : $"{returnUrl}&&msg=order id:{orderId} has been deleted");
        }

        [HttpPost]
        public IActionResult DeleteProduct(long orderId, long productId, string returnUrl)
        {
            try
            {
                lock (OrderRepository.OrdersSyncObj)
                {
                    var order = _orderRepository.Get(orderId, true);
                    if (order == null)
                    {
                        return RedirectToAction(nameof(Index), "Order",
                            new {msg = "wrong order id"});
                    }

                    var result = order.Cart.CartLines.RemoveAll(line => line.Product.Id == productId);
                    if (result > 1)
                    {
                        throw new Exception(
                            $"Something going wrong when trying delete product with id:{productId}, " +
                            $"from order id:{orderId}");
                    }

                    _orderRepository.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index), "Order",
                    new {msg = "db problems"});
            }

            return Redirect(returnUrl.Contains("&&msg=") //todo with format
                ? $"{returnUrl}  product(id:{productId}) has been deleted from order(id:{orderId})"
                : $"{returnUrl}&&msg=product(id:{productId}) has been deleted from order(id:{orderId})");
        }
    }
}