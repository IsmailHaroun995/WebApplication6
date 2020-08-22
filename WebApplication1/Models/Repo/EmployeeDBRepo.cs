using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Repo
{
    public class EmployeeDBRepo : IWeb<Emps>
    {
        WebDbContext db;
        public EmployeeDBRepo(WebDbContext _db)
        {
            db = _db;
           
        }
        public void Add(Emps entity)
        {
            db.Emps.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = Find(id);
            db.Emps.Remove(emp);
            db.SaveChanges();
        }

        public Emps Find(int id)
        {
            var emp = db.Emps.SingleOrDefault(b => b.Id == id);
            return emp;
        }

        public IList<Emps> List()
        {
            return db.Emps.ToList();
        }

        public void Update(int Id, Emps newEm)
        {
            db.Update(newEm);
            db.SaveChanges();
        }
    
    }
}
