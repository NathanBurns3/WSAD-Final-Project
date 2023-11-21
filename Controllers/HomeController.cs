using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WSAD_Final_Project.Models;

namespace WSAD_Final_Project.Controllers;

public class HomeController : Controller
{
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

    public IActionResult Nathan()
    {
        Console.WriteLine("Nathan");
        return View("Nathan");
    }

    public IActionResult Tom()
    {
        return View("Tom");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
