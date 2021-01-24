using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FMS.MultiTenancy.Dto;

namespace FMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

