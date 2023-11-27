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
            return View(_context.golfGears.ToList());
        }
    }
}
