using Abp.Authorization;
using Abp.Runtime.Session;
using JSFileSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace JSFileSystem.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : JSFileSystemAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
