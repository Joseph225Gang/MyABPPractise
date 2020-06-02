using Abp.Authorization;
using MyABPPractise.Authorization.Roles;
using MyABPPractise.Authorization.Users;

namespace MyABPPractise.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
