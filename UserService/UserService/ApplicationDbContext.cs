using Microsoft.EntityFrameworkCore;
using UserService.Enums;
using UserService.Models;

namespace UserService
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyVacancies> CompanyVacancies { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<HR> HRs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectVacancies> ProjectVacancies { get;set; }
        public DbSet<Teammates> Teammates { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
