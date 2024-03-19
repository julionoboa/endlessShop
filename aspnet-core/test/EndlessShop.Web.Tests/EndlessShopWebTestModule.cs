using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EndlessShop.EntityFrameworkCore;
using EndlessShop.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EndlessShop.Web.Tests
{
    [DependsOn(
        typeof(EndlessShopWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EndlessShopWebTestModule : AbpModule
    {
        public EndlessShopWebTestModule(EndlessShopEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EndlessShopWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EndlessShopWebMvcModule).Assembly);
        }
    }
}