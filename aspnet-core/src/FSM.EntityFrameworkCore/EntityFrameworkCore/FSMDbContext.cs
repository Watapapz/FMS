using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FSM.Authorization.Roles;
using FSM.Authorization.Users;
using FSM.MultiTenancy;

namespace FSM.EntityFrameworkCore
{
    public class FSMDbContext : AbpZeroDbContext<Tenant, Role, User, FSMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FSMDbContext(DbContextOptions<FSMDbContext> options)
            : base(options)
        {
        }
    }
}
