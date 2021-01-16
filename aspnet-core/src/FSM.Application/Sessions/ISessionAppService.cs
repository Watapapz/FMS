using System.Threading.Tasks;
using Abp.Application.Services;
using FSM.Sessions.Dto;

namespace FSM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
