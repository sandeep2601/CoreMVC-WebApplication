using Microsoft.EntityFrameworkCore;

namespace CoreMVC_WebApplication.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }

        public DbSet<Student> tbl_Student { get; set; }

        public DbSet<Departments> tbl_Departments { get; set; }
    }
}
