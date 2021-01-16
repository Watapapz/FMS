using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FSM.MultiTenancy.Dto;

namespace FSM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

