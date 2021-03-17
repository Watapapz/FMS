using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FMS.Authorization.Roles;
using FMS.Authorization.Users;
using FMS.MultiTenancy;
using Abp.Domain.Repositories;
using FMS.EntityFrameworkCore.Repositories;
using FMS.Core.Currencies;

namespace FMS.EntityFrameworkCore
{

    [AutoRepositoryTypes(
    typeof(IRepository<>),
    typeof(IRepository<,>),
    typeof(FMSRepositoryBase<>),
    typeof(FMSRepositoryBase<,>)
    )]
    public class FMSDbContext : AbpZeroDbContext<Tenant, Role, User, FMSDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Currency> Currencies { get; set; }

        public FMSDbContext(DbContextOptions<FMSDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
