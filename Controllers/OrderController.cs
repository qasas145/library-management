using DTOS;
using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller {
    private readonly IRepository<Order> _repository;
    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger, IRepository<Order> repository) {
        _logger = logger;
        _repository = repository;
    }
    public IActionResult PlaceHolder(Order order) {
        _repository.Add(order);
        return View();
    }
    public IActionResult Cart() {
        return View();
    }
    public IActionResult OrderHistory() {
        var orders = _repository.GetAll().Select(o=>new OrderDTO(){Id = o.Id, OrderDate = o.OrderDate, TotalAmount = o.TotalAmount, UserId = o.UserId});
        return View(orders);
    }
}