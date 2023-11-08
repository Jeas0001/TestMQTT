using Microsoft.EntityFrameworkCore;
using Model;

namespace EntityFramework
{
    public class MeasurementsContext : DbContext
    {
        public DbSet<Measurements> measurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }
    }
}