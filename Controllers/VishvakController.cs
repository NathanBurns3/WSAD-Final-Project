using Microsoft.AspNetCore.Mvc;
using WSAD_Final_Project.Models;

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
    }
}
