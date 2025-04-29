using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using JSFileSystem.Authorization.Users;
using JSFileSystem.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace JSFileSystem;

/// <summary>
/// Derive your application services from this class.
/// </summary>
public abstract class JSFileSystemAppServiceBase : ApplicationService
{
    public TenantManager TenantManager { get; set; }

    public UserManager UserManager { get; set; }

    protected JSFileSystemAppServiceBase()
    {
        LocalizationSourceName = JSFileSystemConsts.LocalizationSourceName;
    }

    protected virtual async Task<User> GetCurrentUserAsync()
    {
        var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
        if (user == null)
        {
            throw new Exception("There is no current user!");
        }

        return user;
    }

    protected virtual Task<Tenant> GetCurrentTenantAsync()
    {
        return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
    }

    protected virtual void CheckErrors(IdentityResult identityResult)
    {
        identityResult.CheckErrors(LocalizationManager);
    }
}
