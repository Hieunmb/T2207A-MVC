using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T2207A_MVC.Entities;
using T2207A_MVC.Models;

namespace T2207A_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DataContext _context;

        public DepartmentController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var departments = _context.Department.ToList();
            return View(departments);
        }
        // GET /Departments/Create - Show create form
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentViewModel model)
        {
            if (ModelState.IsValid) // validate
            {
                _context.Department.Add(new Department_Tbl { Name = model.Name,Code=model.Code,Location=model.Location,NumberOfEmployees=model.NumberOfEmployees });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(int Id)
        {
            Department_Tbl department = await _context.Department.FindAsync(Id);
            if (department == null)
            {
                return NotFound();
            }

            return View(new DepartmentEditModel { Name = department.Name, Code = department.Code, Location = department.Location, NumberOfEmployees = department.NumberOfEmployees });
        }

        [HttpPost]
        public IActionResult Edit(DepartmentEditModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Department.Update(new Department_Tbl
                {
                    Id = model.Id,
                    Name = model.Name,
                    Code = model.Code,
                    Location = model.Location,
                    NumberOfEmployees = model.NumberOfEmployees
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            Department_Tbl department = _context.Department.Find(Id);
            if (department == null)
            {
                return NotFound();
            }
            _context.Department.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST /Departments/Create - Handle create
    }
}
