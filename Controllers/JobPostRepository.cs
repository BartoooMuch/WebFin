using System.Collections.Generic;
using System.Linq;
using WebFin.Models;

namespace WebFin.Repositories
{
    public class JobPostRepository
    {
        private readonly ApplicationDbContext _context;

        public JobPostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<JobPost> GetAllJobs()
        {
            return _context.JobPosts.ToList();
        }

        public JobPost GetJobById(int id)
        {
            return _context.JobPosts.FirstOrDefault(j => j.Id == id);
        }
    }
}
