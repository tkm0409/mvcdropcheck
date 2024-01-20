using DropdownCheck.Models;
using Microsoft.EntityFrameworkCore;

namespace DropdownCheck.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }

}
