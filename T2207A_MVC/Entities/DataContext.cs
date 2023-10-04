using System;
using Microsoft.EntityFrameworkCore;

namespace T2207A_MVC.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department_Tbl> Department { get; set; }
        public DbSet<Employee_Tbl> Employees { get; set; }
        // soft delete
        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}
    }
}
