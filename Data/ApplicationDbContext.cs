using Microsoft.EntityFrameworkCore;
using PBT819.Models;

namespace PBT819.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
            {
            }
        }
          public DbSet<Person> Person{get; set;}
    }
}