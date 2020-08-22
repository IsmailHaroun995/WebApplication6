using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Repo
{
    public class DepartmentRepo : IWeb<Department>
    {
        List<Department> Department;
        public DepartmentRepo()
        {
            Department = new List<Department>()
            {
               new Department{Id=3,Name="test"}

            };
        }
        public void Add(Department entity)
        {
            Department.Add(entity);
        }

        public void Delete(int id)
        {
            var dep = Find(id);
            Department.Remove(dep);
        }

        public Department Find(int id)
        {
            var dep = Department.SingleOrDefault(b => b.Id == id);
            return dep;
        }

        public IList<Department> List()
        {
            return Department;
        }


        public void Update(int Id, Department entity)
        {
            var dep = Department.SingleOrDefault(s => s.Id == Id);
            dep.Name = entity.Name;
        }
    }
}
