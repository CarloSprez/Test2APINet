using ApiTest2.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTest2.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }

    }
}
