using DAL.Entities;
using DALNEW.Functions;
using DALNEW.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGIC.UserLogic
{
    public class UserLogic 
    {
        private IEmployee IEmp;
        public UserLogic(IEmployee IEmp)
        {
            this.IEmp = IEmp;       
        }
        public UserLogic()
        {

        }

        public async Task<Boolean> CreateNewUser(EmpInDAL emp) 
        {
            try
            {
                var result = await IEmp.AddEmp(emp);
                return true;          
                
            }
            catch(Exception e)
            {
                return false;

            }
        }

        public async Task<List<EmpInDAL>> GetAllUser()
        {
            List<EmpInDAL> emps = await IEmp.GetALlEmployee();
            return emps;
        }
        public void DeleteById(Guid id)
        {
            var emp = IEmp.DeleteById(id);
        }
    }
}
