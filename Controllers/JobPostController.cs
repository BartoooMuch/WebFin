using Microsoft.AspNetCore.Mvc;
using WebFin.Models;
using WebFin.ViewModels;
using System.Linq;

namespace WebFin.Controllers
{
    public class JobPostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobPostController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            var job = _context.JobPosts
                .Where(j => j.Id == id)
                .Select(j => new JobPostViewModel
                {
                    Id = j.Id,
                    Title = j.Title,
                    Description = j.Description,
                    City = j.City,
                    LastUpdated = j.LastUpdated,
                    CompanyName = j.Company.Name
                })
                .FirstOrDefault();

            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }
    }
}
