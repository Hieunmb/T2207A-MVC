using System;
using System.ComponentModel.DataAnnotations;
namespace T2207A_MVC.Models
{
    public class DepartmentViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [MinLength(6, ErrorMessage = "Vui lòng nhập tối thiểu 6 ký tự")]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int NumberOfEmployees { get; set; }

    }
}
