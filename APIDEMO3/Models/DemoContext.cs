using Microsoft.EntityFrameworkCore;

namespace APIDEMO3.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }



    }
}
