using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Repo
{
    public class EmpRepo : IWeb<Emps>
    {
        List<Emps> Employees;
        public EmpRepo()
        {
            Employees = new List<Emps>()
            {
               new Emps{FirstName="ff"}
               
            };
        }
        public void Add(Emps entity)
        {
            Employees.Add(entity);
        }

        public void Delete(int id)
        {
            var emp = Find(id);
            Employees.Remove(emp);
        }

        public Emps Find(int id)
        {
            var emp = Employees.SingleOrDefault(b => b.Id == id);
            return emp;
        }

        public IList<Emps> List()
        {
            return Employees;
        }

        public void Update(int Id,Emps newEm)
        {
            var emp = Employees.SingleOrDefault(s => s.Id == Id);
            emp.FirstName = newEm.FirstName;
            emp.LastName = newEm.LastName;
            emp.Gender = newEm.Gender;
            emp.OnTimeCreated = newEm.OnTimeCreated;
            emp.Address = newEm.Address;
            emp.Email = newEm.Email;
            emp.Mobile = newEm.Mobile;
            emp.UserName = newEm.UserName;
            emp.Password = newEm.Password;
        }
    }
}
