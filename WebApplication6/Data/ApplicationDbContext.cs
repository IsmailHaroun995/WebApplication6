using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<WebApplication6.Models.Employee> Employee { get; set; }
        public DbSet<WebApplication6.Models.Department> Department { get; set; }
        public DbSet<WebApplication6.Models.NewEmployee> NewEmployee { get; set; }
    }
}
