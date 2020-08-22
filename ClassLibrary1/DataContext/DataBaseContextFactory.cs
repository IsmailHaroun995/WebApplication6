using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataContext
{
    class DataBaseContextFactory:IDesignTimeDbContextFactory<DataBaseContext>
    {
        public DataBaseContext CreateDbContext(string[] args) 
        {
            AppConfigration appConfig = new AppConfigration();
            var opsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
            opsBuilder.UseSqlServer(appConfig.SqlConnString);
            return new DataBaseContext(opsBuilder.Options);
        }
    }
}
