using Microsoft.EntityFrameworkCore;
namespace ChartDemo.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Sales> Sales { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
