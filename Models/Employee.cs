using System.ComponentModel.DataAnnotations;

namespace pos_employee.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public String Department { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
