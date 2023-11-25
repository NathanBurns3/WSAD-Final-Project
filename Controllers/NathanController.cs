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

    public ViewResult Index()
    {
        var gear = data.SnowboardGear
            .OrderBy(g => g.GearType)
            .ThenBy(g => g.Brand)
            .ThenBy(g => g.Model)
            .ToList();
        return View(gear);

    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var gear = data.SnowboardGear.Find(id);
        return View(gear);
    }

    [HttpPost]
    public IActionResult Edit(SnowboardGear gear)
    {
        if (ModelState.IsValid)
        {
            try
            {
                data.Update(gear);
                data.SaveChanges();
                TempData["Message"] = $"{gear.Brand} {gear.Model} edited successfully!";
            }
            catch
            {
                TempData["Message"] = $"Failed to edit {gear.Brand} {gear.Model}.";
            }
            return RedirectToAction("Index");
        }
        else
        {
            return View(gear);
        }
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var gear = data.SnowboardGear.Find(id);
        if (gear != null)
        {
            try
            {
                data.Remove(gear);
                data.SaveChanges();
                TempData["Message"] = $"{gear.Brand} {gear.Model} removed successfully!";
            }
            catch
            {
                TempData["Message"] = $"Failed to remove {gear.Brand} {gear.Model}.";
            }
        }
        else
        {
            TempData["Message"] = $"Failed to find {id}.";
        }
        return RedirectToAction("Index");
    }

    [HttpGet]
    public ViewResult Add()
    {
        return View(new SnowboardGear());
    }

    [HttpPost]
    public IActionResult Add(SnowboardGear gear)
    {
        if (ModelState.IsValid)
        {
            try
            {
                data.Add(gear);
                data.SaveChanges();
                TempData["Message"] = $"{gear.Brand} {gear.Model} added successfully!";
                return RedirectToAction("Index");
            }
            catch
            {
                TempData["Message"] = $"Failed to add {gear.Brand} {gear.Model}.";
            }
        }
        return View(gear);
    }
}
