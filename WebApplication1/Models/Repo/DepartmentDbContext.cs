using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Repo
{
    public class DepartmentDbContext : IWeb<Department>
    {
        WebDbContext db;
        public DepartmentDbContext(WebDbContext _db)
        {
            db = _db;   
        }
        public void Add(Department entity)
        {
            db.Department.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var dep = Find(id);
            db.Department.Remove(dep);
            db.SaveChanges();
        }

        public Department Find(int id)
        {
            var dep = db.Department.SingleOrDefault(b => b.Id == id);
            return dep;
        }

        public IList<Department> List()
        {
            return db.Department.ToList();
        }


        public void Update(int Id, Department entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    
    }
}
