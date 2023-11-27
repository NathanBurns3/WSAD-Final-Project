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

        public IActionResult Index()
        {
            return View(_context.Games.ToList());
        }
    }
}
