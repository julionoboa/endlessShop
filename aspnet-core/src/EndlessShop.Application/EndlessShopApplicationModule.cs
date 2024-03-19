using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EndlessShop.Authorization;

namespace EndlessShop
{
    [DependsOn(
        typeof(EndlessShopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EndlessShopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EndlessShopAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EndlessShopApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
