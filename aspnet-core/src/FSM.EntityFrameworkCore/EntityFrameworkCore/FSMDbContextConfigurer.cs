using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FSM.EntityFrameworkCore
{
    public static class FSMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FSMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FSMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
