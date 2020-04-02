using Microsoft.EntityFrameworkCore;

namespace CRUDDOTNETCOREAPP.Models
{
    public class CMSContext : DbContext
    {
        public CMSContext(DbContextOptions<CMSContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
