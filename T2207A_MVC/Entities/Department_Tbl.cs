using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T2207A_MVC.Entities
{
    [Table("Department")]
    public class Department_Tbl
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int NumberOfEmployees { get; set; }
        [Required]
        public ICollection<Employee_Tbl> Employees { get; set; }
    }
}
