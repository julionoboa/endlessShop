using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EndlessShop.Configuration;

namespace EndlessShop.Web.Host.Startup
{
    [DependsOn(
       typeof(EndlessShopWebCoreModule))]
    public class EndlessShopWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EndlessShopWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EndlessShopWebHostModule).GetAssembly());
        }
    }
}
