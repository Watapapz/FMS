using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FMS.Configuration;
using FMS.Web;
using System;

namespace FMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FMSDbContextFactory : IDesignTimeDbContextFactory<FMSDbContext>
    {
        public FMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FMSDbContext>();
            string env = null;

            env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";
            Console.WriteLine($"Environment : {env}");
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), env);
            Console.WriteLine($"Connection : {configuration.GetConnectionString(FMSConsts.ConnectionStringName)}");
            FMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FMSConsts.ConnectionStringName));

            return new FMSDbContext(builder.Options);
        }
    }
}
