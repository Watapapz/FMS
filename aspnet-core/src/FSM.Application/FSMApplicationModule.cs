using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FSM.Authorization;

namespace FSM
{
    [DependsOn(
        typeof(FSMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FSMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FSMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FSMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
