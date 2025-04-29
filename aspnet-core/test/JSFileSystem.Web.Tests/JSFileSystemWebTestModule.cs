using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JSFileSystem.EntityFrameworkCore;
using JSFileSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace JSFileSystem.Web.Tests;

[DependsOn(
    typeof(JSFileSystemWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class JSFileSystemWebTestModule : AbpModule
{
    public JSFileSystemWebTestModule(JSFileSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(JSFileSystemWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(JSFileSystemWebMvcModule).Assembly);
    }
}