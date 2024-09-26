using Day_1.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day_1.DAL.DB
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MVC1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
