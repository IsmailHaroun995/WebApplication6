using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class WebDbContext:DbContext
    {
        public WebDbContext()
        {
                
        }
        public DbSet<Emps> Emps { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
