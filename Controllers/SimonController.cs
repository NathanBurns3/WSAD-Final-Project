using Microsoft.AspNetCore.Mvc;
using WSAD_Final_Project.Models;

namespace WSAD_Final_Project.Controllers
{
    public class SimonController : Controller
    {
        private HobbyContext _context { get; set; }
        public SimonController(HobbyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var gear = _context.golfGears
            .OrderBy(g => g.Id)
            .ThenBy(g => g.Name)
            .ToList();
            return View(gear);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var gear = _context.golfGears.Find(id);
            return View(gear);
        }

        [HttpPost]
        public IActionResult Edit(GolfGear gear)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gear);
                    _context.SaveChanges();
                    TempData["Message"] = $"{gear.Name} edited successfully!";
                }
                catch
                {
                    TempData["Message"] = $"Failed to edit {gear.Name}.";
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
            var gear = _context.golfGears.Find(id);
            if (gear != null)
            {
                try
                {
                    _context.Remove(gear);
                    _context.SaveChanges();
                }
                catch
                {
                    ModelState.AddModelError("", "Falied to remove gear");
                }
            }
            else
            {
                ModelState.AddModelError("", "Falied to find id");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Add() => View(new GolfGear());

        [HttpPost]
        public IActionResult Add(GolfGear gear)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(gear);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Falied to add gear");
                }
            }
            return View(gear);
        }
    }
}
