using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T2207A_MVC.Entities
{
    [Table("Employee")]
    public class Employee_Tbl
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public Department_Tbl Department { get; set; }
        [Required]
        public string Rank { get; set; }
    }
}
