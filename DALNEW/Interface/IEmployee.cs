using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DALNEW.Interface
{
    public interface IEmployee
    {
        Task<EmpInDAL> AddEmp(EmpInDAL emp);
        Task<List<EmpInDAL>> GetALlEmployee();
        Task DeleteById(Guid Id);
    }
}
