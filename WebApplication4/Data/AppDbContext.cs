using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // Define table names 
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> People { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
