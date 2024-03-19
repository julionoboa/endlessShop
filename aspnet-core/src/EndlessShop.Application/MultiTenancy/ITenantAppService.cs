using Abp.Application.Services;
using EndlessShop.MultiTenancy.Dto;

namespace EndlessShop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

