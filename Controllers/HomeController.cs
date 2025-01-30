using Microsoft.AspNetCore.Mvc;
using WebFin.Models;
using System.Linq;

namespace WebFin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var jobs = _context.JobPosts.Take(5).ToList();
            return View(jobs);
        }
    }
}
