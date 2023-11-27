using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WSAD_Final_Project.Models;

namespace WSAD_Final_Project.Controllers;

public class TomController : Controller
{
    private CarsContext data { get; set; }

    public TomController(CarsContext ctx)
    {
        data = ctx;
    }

    public ViewResult Index()
    {
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

    [HttpPost]
    public IActionResult Add(Cars car)
    {
        if (ModelState.IsValid)
        {
            try
            {
                data.Cars.Add(car);
                data.SaveChanges();
                TempData["SuccessMessage"] = "Car added successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
        }
        return View(car);
    }

    [HttpGet]
    public ViewResult Add() => View(new Cars());

    [HttpGet]
    public ViewResult Edit(int id)
    {
        try
        {
            var car = data.Cars.Find(id);
            return View(car);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    [HttpPost]
    public IActionResult Edit(Cars car)
    {
        if (ModelState.IsValid)
        {
            try
            {
                data.Cars.Update(car);
                data.SaveChanges();
                TempData["SuccessMessage"] = "Car updated successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
        }
        return View(car);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        try
        {
            var car = data.Cars.Find(id);
            if (car != null)
            {
                data.Cars.Remove(car);
                data.SaveChanges();
                TempData["SuccessMessage"] = $"{car.CarMake} {car.CarModel} was deleted";
            }
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
