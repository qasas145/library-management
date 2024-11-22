using Microsoft.AspNetCore.Mvc;

public class AdminController : Controller{
    private readonly IRepository<Order> _orderRepo;
    private readonly IRepository<Book> _bookRepo;
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger, IRepository<Order> _orderRepo, IRepository<Book> _bookRepo) {
        _logger = logger;
        this._orderRepo = _orderRepo;
        this._bookRepo = _bookRepo;
    }
    public IActionResult ManageBooks() {
        IEnumerable<Book> books = _bookRepo.GetAll();
        return View(books);
    }
    public IActionResult ManageOrders() {
        IEnumerable<Order> orders = _orderRepo.GetAll();
        return View(orders);
    }
}