using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webShopSolution.Data.EF
{
    public class WebShopDbContextFactory : IDesignTimeDbContextFactory<WebShopDbContext>
    {
        public WebShopDbContext CreateDbContext(string[] args)
        {
            //lay connectionConfig = tao 1 ConfigurationBuilder
            //setbasepasth la thu muc hien tai
            //addJsonFile = appsetting.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("webShopSolutionDb");//lay connectionstring
            var optionBuilder = new DbContextOptionsBuilder<WebShopDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new WebShopDbContext(optionBuilder.Options);
        }
    }
}
