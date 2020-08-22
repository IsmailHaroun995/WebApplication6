using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Repo;

namespace WebApplication1.Controllers
{
    public class DepartmentsController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IWeb<Department> DepRepo;

        public DepartmentsController(IWeb<Department> _DepRepo)
        {
            DepRepo = _DepRepo;
        }

        // GET: Departments
        public IActionResult Index()
        {
            var de = DepRepo.List();
            return View(de);
        }

        // GET: Departments/Details/5
        public IActionResult Details(int id)
        {
            var e = DepRepo.Find(id);
            return View(e);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department department)
        {
            try
            {
                DepRepo.Add(department);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Content("error");
            }
        }

        // GET: Departments/Edit/5
        public IActionResult Edit(int id)
        {
            var d = DepRepo.Find(id);
            return View(d);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Department department)
        {
            try
            {
                DepRepo.Update(id, department);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return Content("error");

            }
        }

        // GET: Departments/Delete/5
        public IActionResult Delete(int id)
        {
            var d = DepRepo.Find(id);
            return View(d);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                DepRepo.Delete(id);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return Content("error");
            }
        }

        //private bool DepartmentExists(int id)
        //{
        //    return _context.Departments.Any(e => e.Id == id);
        //}
    }
}
