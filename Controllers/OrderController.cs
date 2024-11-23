using System.Text.Json;
using DTOS;
using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller {
    private readonly IRepository<Order> _repository;
    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger, IRepository<Order> repository) {
        _logger = logger;
        _repository = repository;
    }
    [HttpPost]
    public IActionResult PlaceHolder(Cart cart) {
        var order = new Order();
        var userId = cart.UserId;
        order.OrderDate = DateTime.Now;
        order.OrderItems = cart.CartItems.Select(c=>new OrderItem(){BookId = c.BookId, Quantity = c.Quantity, Price = c.Price}).ToList();
        order.UserId = userId;
        _repository.Add(order);
        return Ok("The order has been confirmed succesfully");
    }
    public IActionResult Cart() {
        var cart = JsonSerializer.Deserialize<Cart>(HttpContext.Session.GetString("cart"));
        var cartDTO = new CartDTO(){Id = cart.Id, cartItems = cart.CartItems, UserId = cart.UserId};
        return View(cartDTO);
    }
    public IActionResult OrderHistory() {
        var orders = _repository.GetAll().Select(o=>new OrderDTO(){Id = o.Id, OrderDate = o.OrderDate, TotalAmount = o.TotalAmount, UserId = o.UserId, TotalPrice = o.TotalPrice});
        return View(orders);
    }
}