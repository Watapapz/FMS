using System.Threading.Tasks;
using FSM.Configuration.Dto;

namespace FSM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
