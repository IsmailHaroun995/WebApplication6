using Microsoft.Extensions.Configuration;
using System.IO;


namespace DAL.DataContext
{
    public class AppConfigration
    {
        public AppConfigration()
        {
            var configBuilder = new ConfigurationBuilder();
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "appsetting.json");
            var path = new ConfigurationBuilder() .SetBasePath(Directory.GetCurrentDirectory()) .AddJsonFile("appsettings.json");
            //configBuilder.AddJsonFile(path, false);
            var root = configBuilder.Build();
            var appSetting = root.GetSection("ConnectionStrings:DefaultConnection");
            SqlConnString = appSetting.Value;
        }
        public string SqlConnString { get; set; }
    }
}
