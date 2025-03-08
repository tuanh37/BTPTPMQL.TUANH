using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet cho Employee
        public DbSet<Employee> Employees { get; set; }

        // Nếu bạn muốn thêm DbSet cho Person
        public DbSet<Person> Persons { get; set; }
    }
}
