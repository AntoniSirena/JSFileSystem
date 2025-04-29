using Abp.Application.Services;
using JSFileSystem.Sessions.Dto;
using System.Threading.Tasks;

namespace JSFileSystem.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
