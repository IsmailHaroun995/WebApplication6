using DAL.DataContext;
using DAL.Entities;
using DALNEW.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DALNEW.Functions
{
    public class EmployeeFunctions : IEmployee
    {
        //DAL.Entities.EmpInEntites e = new EmpInEntites();
        private readonly string _connectionString;
        public EmployeeFunctions()
        {

        }
        public EmployeeFunctions(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("defaultConnection");
        }
        public async Task<EmpInDAL> AddEmp(EmpInDAL emp)
        {
            EmpInDAL newemp = new EmpInDAL
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Gender = emp.Gender,
                dateTime = emp.dateTime,
                Address = emp.Address,
                Email = emp.Email,
                Mobile = emp.Mobile,
                UserName = emp.UserName,
                Password = emp.Password,
                ConfirmPassword = emp.ConfirmPassword

            };
            using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
            {
                await context.Emp.AddAsync(newemp);
                await context.SaveChangesAsync();
            }
            return newemp;
        }
        public async Task<List<EmpInDAL>> GetALlEmployee()
        {
            try
            {
                List<EmpInDAL> Emps = new List<EmpInDAL>();
                var x = DataBaseContext.ops.dbOptions;
                var con = new DataBaseContext(DataBaseContext.ops.dbOptions);
                using (var context = new DataBaseContext(DataBaseContext.ops.dbOptions))
                {
                    Emps = await context.Emp.ToListAsync();

                }
                return Emps;

            }
            catch (Exception e)
            {
                throw ;
            }
            
        }
        public async Task DeleteById(Guid Id)

        {

            using (SqlConnection sql = new SqlConnection(_connectionString))

            {

                using (SqlCommand cmd = new SqlCommand("DeleteEmployee", sql))

                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id", Id));

                    await sql.OpenAsync();

                    await cmd.ExecuteNonQueryAsync();

                    return;

                }

            }

        }
    }


}

