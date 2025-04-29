using Abp.Application.Services;
using JSFileSystem.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace JSFileSystem.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
