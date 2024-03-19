using System.Threading.Tasks;
using EndlessShop.Configuration.Dto;

namespace EndlessShop.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
