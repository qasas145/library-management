using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using libraryManagment.Models;
using System.Text.Json;

namespace libraryManagment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var cart = new Cart(){UserId = 1, Id = 1};
        var cartJson = JsonSerializer.Serialize(cart);
        HttpContext.Session.SetString("cart", cartJson);
        Console.WriteLine("The cart has been added");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
