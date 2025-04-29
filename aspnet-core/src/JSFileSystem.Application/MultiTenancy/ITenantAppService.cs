using Abp.Application.Services;
using JSFileSystem.MultiTenancy.Dto;

namespace JSFileSystem.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

