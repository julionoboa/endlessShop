using System.Threading.Tasks;
using Abp.Application.Services;
using EndlessShop.Authorization.Accounts.Dto;

namespace EndlessShop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
