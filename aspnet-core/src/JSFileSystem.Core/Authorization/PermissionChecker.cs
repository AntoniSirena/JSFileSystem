using Abp.Authorization;
using JSFileSystem.Authorization.Roles;
using JSFileSystem.Authorization.Users;

namespace JSFileSystem.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
