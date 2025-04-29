using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JSFileSystem.Controllers
{
    public abstract class JSFileSystemControllerBase : AbpController
    {
        protected JSFileSystemControllerBase()
        {
            LocalizationSourceName = JSFileSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
