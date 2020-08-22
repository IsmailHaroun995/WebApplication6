using DAL.Entities;
using LOGIC.UserLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.API
{
    [Route("api/Employees")]
    [ApiController]
    public class Emp_API : ControllerBase
    {
        private UserLogic UL = new UserLogic();
        [Route("add")]
        [HttpGet]
        public async Task<Boolean> AddUser(NewEmployee e )
        {
            EmpInDAL newemp = new EmpInDAL
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Gender = e.Gender,
                dateTime = e.OnTimeCreated,
                Address = e.Address,
                Email = e.Email,
                Mobile = e.Mobile,
                UserName = e.UserName,
                Password = e.Password,
                ConfirmPassword = e.ConfirmPassword

            };
            bool result = await UL.CreateNewUser(newemp);
            return result;
        }


        [Route("add")]
        [HttpGet]
        public async Task<List<NewEmployee>> GetAllEmployeee()
        {
            List<NewEmployee> empList = new List<NewEmployee>();
             var emps = await UL.GetAllUser();
            if (emps.Count >0)
            {
                foreach (var emp in emps)
                {
                    NewEmployee em = new NewEmployee
                    {
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        Gender = emp.Gender,
                        OnTimeCreated = emp.dateTime,
                        Address = emp.Address,
                        Email = emp.Email,
                        Mobile = emp.Mobile,
                        UserName = emp.UserName,
                        Password = emp.Password,
                        ConfirmPassword = emp.ConfirmPassword
                    };
                    empList.Add(em);

                }

            }
            return empList;
        }



    }
}
