using Abp.Modules;
using Abp.Reflection.Extensions;
using JSFileSystem.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace JSFileSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(JSFileSystemWebCoreModule))]
    public class JSFileSystemWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JSFileSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JSFileSystemWebHostModule).GetAssembly());
        }
    }
}
