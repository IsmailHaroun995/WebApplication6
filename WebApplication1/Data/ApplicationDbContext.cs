﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<WebApplication1.Models.Employee> Employee { get; set; }
        public DbSet<WebApplication1.Models.Department> Departments { get; set; }
        public DbSet<WebApplication1.Models.Emps> Emps { get; set; }
       
    }
}
