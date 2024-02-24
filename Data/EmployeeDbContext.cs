using Microsoft.EntityFrameworkCore;
using pos_employee.Models;

namespace pos_employee.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
