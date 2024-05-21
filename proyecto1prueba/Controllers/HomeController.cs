using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using proyecto1prueba.Models;

namespace proyecto1prueba.Controllers;

public class HomeController : Controller
{
    public IActionResult Admin()
    {
        return View();
    }

    public IActionResult Ayuda()
    {
        return View();
    }

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

