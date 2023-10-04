using System;
using System.ComponentModel.DataAnnotations;
namespace T2207A_MVC.Models
{
    public class CategoryViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [MinLength(6, ErrorMessage = "Vui lòng nhập tối thiểu 6 ký tự")]
        public string name { get; set; }
    }
}