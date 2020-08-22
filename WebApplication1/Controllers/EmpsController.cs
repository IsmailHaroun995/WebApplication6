using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Repo;

namespace WebApplication1.Controllers
{
    public class EmpsController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IWeb<Emps> EmpRepo;
        private readonly IWeb<Department> DepRep;

        public EmpsController(IWeb<Emps> _EmpRepo,IWeb<Department> DepRep)
        {
            //_context = context;
            this.EmpRepo = _EmpRepo;
            this.DepRep = DepRep;
        }

        // GET: Emps
        public IActionResult Index()
        {
            var em = EmpRepo.List();
            return View(em);
        }

        // GET: Emps/Details/5
        public IActionResult Details(int id)
        {
            var e = EmpRepo.Find(id);
            return View(e);
        }

        // GET: Emps/Create
        public IActionResult Create()
        {
            var model = new Emps
            {
                Department = DepRep.List().ToList()
            };
            return View();
        } 

        // POST: Emps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Emps emps)
        {
            try
            {
                EmpRepo.Add(emps);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Content("error");
            }
        }

        // GET: Emps/Edit/5
        public IActionResult Edit(int id)
        {
            var e = EmpRepo.Find(id);
            return View(e);
           
        }

        // POST: Emps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Emps emps)
        {
            try
            {
                EmpRepo.Update(id, emps);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return Content("error");

            }
        }

        // GET: Emps/Delete/5
        public IActionResult Delete(int id)
        {
            var e = EmpRepo.Find(id);
            return View(e);
        }

        // POST: Emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                EmpRepo.Delete(id);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return Content("error");
            }
        }

        //private bool EmpsExists(int id)
        //{
        //    return _context.Emps.Any(e => e.Id == id);
        //}
    }
}
