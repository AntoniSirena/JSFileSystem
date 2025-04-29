using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JSFileSystem.Authorization;

namespace JSFileSystem;

[DependsOn(
    typeof(JSFileSystemCoreModule),
    typeof(AbpAutoMapperModule))]
public class JSFileSystemApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<JSFileSystemAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(JSFileSystemApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
