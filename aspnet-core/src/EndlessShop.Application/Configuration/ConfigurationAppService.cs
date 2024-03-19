using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EndlessShop.Configuration.Dto;

namespace EndlessShop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EndlessShopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
