using System.Data.Entity;

namespace AutoMapperOnMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("AutoMapperDb")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}