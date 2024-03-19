using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EndlessShop.Controllers
{
    public abstract class EndlessShopControllerBase: AbpController
    {
        protected EndlessShopControllerBase()
        {
            LocalizationSourceName = EndlessShopConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
