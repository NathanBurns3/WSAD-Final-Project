using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSAD_Final_Project.Models;

namespace WSAD_Final_Project.Controllers;

public class NathanController : Controller
{
    private HobbyContext data { get; set; }

    public NathanController(HobbyContext ctx)
    {
        data = ctx;
    }

    public ViewResult Index() {
        try
        {
            Console.WriteLine("HERE IS THE DATA:", data);
            var gear = data.SnowboardGear
                .OrderBy(g => g.GearType)
                .ThenBy(g => g.Brand)
                .ThenBy(g => g.Model)
                .ToList();
            return View(gear);
        }
        catch (Exception ex)
        {
            Console.WriteLine("HERE IS THE ERROR:", ex.Message);
            throw;
        }
    }
}
