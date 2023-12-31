﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace T2207A_MVC.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int id { get; set; }// abstract property
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int category_id { get; set; }
        [ForeignKey("category_id")]
        public Category Category { get; set; }
    }
}
