using DropdownCheck.Models;
using System.Linq;

namespace DropdownCheck.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.People.Any())
            {
                return;   // Data already seeded
            }

            context.People.AddRange(
                new Person { Name = "John Doe", Information = "Info for John" },
                new Person { Name = "Jane Doe", Information = "Info for Jane" }
            );

            context.SaveChanges();
        }
    }

}
