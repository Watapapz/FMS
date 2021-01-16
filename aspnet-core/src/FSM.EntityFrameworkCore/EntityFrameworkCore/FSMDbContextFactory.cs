using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FSM.Configuration;
using FSM.Web;

namespace FSM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FSMDbContextFactory : IDesignTimeDbContextFactory<FSMDbContext>
    {
        public FSMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FSMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FSMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FSMConsts.ConnectionStringName));

            return new FSMDbContext(builder.Options);
        }
    }
}
