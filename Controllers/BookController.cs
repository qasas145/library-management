using System.Text.Json;
using DTOS;
using Microsoft.AspNetCore.Mvc;

public class BookController : Controller {
    private readonly ILogger<BookController> _logger;
    private readonly IRepository<Book> _repository;

    public BookController(ILogger<BookController> logger, IRepository<Book> repository) {
        _logger = logger;
        _repository = repository;
    }
    public IActionResult Index() {
        var books = _repository.GetAll().Select(b=>new BookDTO(){author = b.Author, AverageRating= b.AverageRating, Id = b.Id, Price = b.Price, Title = b.Title});
        return View(books);
    }
    public IActionResult Details([FromRoute]int id) {
        Book b = _repository.GetById(id);
        return View(new BookDTO(){author = b.Author, AverageRating= b.AverageRating, Id = b.Id, Price = b.Price, Title = b.Title});
    }
    [HttpPost]
    public IActionResult AddToCart(CartItem cartItem)  {
        var cart = JsonSerializer.Deserialize<Cart>(HttpContext.Session.GetString("cart"));
        cart.AddToCart(cartItem);
        HttpContext.Session.SetString("cart", JsonSerializer.Serialize(cart));
        return Ok("The book has added to the cart");
    }
}