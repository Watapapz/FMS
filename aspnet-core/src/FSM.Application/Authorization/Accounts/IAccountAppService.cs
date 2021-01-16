using System.Threading.Tasks;
using Abp.Application.Services;
using FSM.Authorization.Accounts.Dto;

namespace FSM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
