using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FSM.Controllers
{
    public abstract class FSMControllerBase: AbpController
    {
        protected FSMControllerBase()
        {
            LocalizationSourceName = FSMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
