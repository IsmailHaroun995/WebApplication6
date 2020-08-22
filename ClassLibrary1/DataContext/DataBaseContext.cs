using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    public class DataBaseContext:DbContext
    {
        public class OptionBuild
        {
            public OptionBuild()
            {
                setting = new AppConfigration();
                opsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
                opsBuilder.UseSqlServer(setting.SqlConnString);
                dbOptions = opsBuilder.Options;
            }
            public DbContextOptionsBuilder<DataBaseContext> opsBuilder { get; set; }
            public DbContextOptions<DataBaseContext> dbOptions { get; set; }

            private AppConfigration setting { get; set; }
        }
        public static OptionBuild ops = new OptionBuild();
        public DataBaseContext(DbContextOptions<DataBaseContext>options):base(options)
        {

        }
        public DbSet<EmpInDAL> Emp { get; set; }

    }
}
