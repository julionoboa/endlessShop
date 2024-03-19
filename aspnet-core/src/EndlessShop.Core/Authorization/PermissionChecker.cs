using Abp.Authorization;
using EndlessShop.Authorization.Roles;
using EndlessShop.Authorization.Users;

namespace EndlessShop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
