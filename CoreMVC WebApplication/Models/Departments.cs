using System.ComponentModel.DataAnnotations;

namespace CoreMVC_WebApplication.Models
{
    public class Departments
    {
        [Key]
        public int ID { get; set; }

        public string? Department { get; set; }
    }
}
