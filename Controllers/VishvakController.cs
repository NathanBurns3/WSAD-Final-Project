using Microsoft.AspNetCore.Mvc;
using WSAD_Final_Project.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WSAD_Final_Project.Controllers
{
    public class VishvakController : Controller
    {
        private GamesContext _context {  get; set; }

        public VishvakController(GamesContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            var games = _context.Games
            .OrderBy(c => c.ReleaseYear)
            .ThenBy(c => c.Developer)
            .ThenBy(c => c.Title)
            .ToList();

            return View(games);
        }

        [HttpGet]
        public ViewResult Add() => View(new Videogames());

        [HttpPost]
        public IActionResult Add(Videogames game)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Add(game);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Please correct all errors");
                return View(game);
            }
        }

        [HttpGet]
        public ViewResult Edit(int id) 
        {
            var game = _context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Videogames game)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Update(game);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Please correct all errors");
                return View(game);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var game = _context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(Videogames game)
        {
            _context.Games.Remove(game);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
