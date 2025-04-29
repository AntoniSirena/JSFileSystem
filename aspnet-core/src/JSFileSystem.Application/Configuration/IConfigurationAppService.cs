using JSFileSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace JSFileSystem.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
