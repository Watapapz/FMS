using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FMS.Configuration;
using FMS.Web;

namespace FMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FMSDbContextFactory : IDesignTimeDbContextFactory<FMSDbContext>
    {
        public FMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FMSConsts.ConnectionStringName));

            return new FMSDbContext(builder.Options);
        }
    }
}
