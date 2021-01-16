using Abp.Authorization;
using FSM.Authorization.Roles;
using FSM.Authorization.Users;

namespace FSM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
