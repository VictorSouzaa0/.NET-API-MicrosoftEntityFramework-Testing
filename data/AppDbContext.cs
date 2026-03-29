using Microsoft.EntityFrameworkCore;
using ProjectF1.Models;

namespace ProjectF1.data
{
    public class AppDbContext: DbContext
    {
        //All settings of my database 
        public AppDbContext(DbContextOptions options): base (options) {}

        public DbSet<Drivers> DRV {get; set;}
    }
}