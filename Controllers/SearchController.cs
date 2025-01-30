using Microsoft.AspNetCore.Mvc;
using WebFin.Models;
using System.Linq;

namespace WebFin.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult SearchResults(string city)
        {
            var jobs = _context.JobPosts.Where(j => j.City.Contains(city)).ToList();
            return View(jobs);
        }
    }
}
