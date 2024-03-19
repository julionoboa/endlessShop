using System.Threading.Tasks;
using Abp.Application.Services;
using EndlessShop.Sessions.Dto;

namespace EndlessShop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
