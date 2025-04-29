using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace JSFileSystem.Authorization;

public class JSFileSystemAuthorizationProvider : AuthorizationProvider
{
    public override void SetPermissions(IPermissionDefinitionContext context)
    {
        context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
        context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
        context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
        context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

        context.CreatePermission(PermissionNames.Pages_System, L("System"));
        context.CreatePermission(PermissionNames.Pages_Maintenances, L("Maintenances"));
        context.CreatePermission(PermissionNames.Pages_ConfigurationParameters, L("ConfigurationParameters"));

        context.CreatePermission(PermissionNames.Pages_Students, L("Students"));
        context.CreatePermission(PermissionNames.Pages_Students_GetAll, L("StudentsGetAll"));
        context.CreatePermission(PermissionNames.Pages_Students_Create, L("StudentsCreate"));
        context.CreatePermission(PermissionNames.Pages_Students_Update, L("StudentsUpdate"));
        context.CreatePermission(PermissionNames.Pages_Students_Delete, L("StudentsDelete"));


    }

    private static ILocalizableString L(string name)
    {
        return new LocalizableString(name, JSFileSystemConsts.LocalizationSourceName);
    }
}
