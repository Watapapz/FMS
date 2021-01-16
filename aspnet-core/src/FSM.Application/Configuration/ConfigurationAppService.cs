using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FSM.Configuration.Dto;

namespace FSM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FSMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
