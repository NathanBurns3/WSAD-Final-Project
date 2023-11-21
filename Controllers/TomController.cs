using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSAD_Final_Project.Models;

namespace WSAD_Final_Project.Controllers;

public class TomController : Controller
{
    private CarsContext data { get; set; }

    public TomController(CarsContext ctx)
    {
        data = ctx;
    }

    public ViewResult Index() {
        try
        {
            var cars = data.Cars
                .OrderBy(g => g.BoughtYear)
                .ThenBy(g => g.CarMake)
                .ThenBy(g => g.CarModel)
                .ToList();
            return View(cars);
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
