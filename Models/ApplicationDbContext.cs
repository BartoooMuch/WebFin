using Microsoft.EntityFrameworkCore;

namespace WebFin.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<City> Cities { get; set; }

        public static void SeedData(ApplicationDbContext context)
        {
            if (!context.Companies.Any())
            {
                context.Companies.AddRange(new List<Company>
                {
                    new Company { Name = "Microsoft" },
                    new Company { Name = "Google" },
                    new Company { Name = "Amazon" }
                });
                context.SaveChanges();
            }

            if (!context.Cities.Any())
            {
                context.Cities.AddRange(new List<City>
                {
                    new City { Name = "İstanbul" },
                    new City { Name = "Ankara" },
                    new City { Name = "İzmir" }
                });
                context.SaveChanges();
            }

            if (!context.JobPosts.Any())
            {
                context.JobPosts.AddRange(new List<JobPost>
                {
                    new JobPost { Title = "Full Stack Developer", Description = "ASP.NET Core & React", City = "İstanbul", CompanyId = 1, LastUpdated = DateTime.Now },
                    new JobPost { Title = "Backend Developer", Description = "C# & SQL Server", City = "Ankara", CompanyId = 2, LastUpdated = DateTime.Now },
                    new JobPost { Title = "Frontend Developer", Description = "React & Tailwind", City = "İzmir", CompanyId = 3, LastUpdated = DateTime.Now }
                });
                context.SaveChanges();
            }
        }
    }
}
