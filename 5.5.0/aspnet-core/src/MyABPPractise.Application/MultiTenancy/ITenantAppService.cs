using Abp.Application.Services;
using MyABPPractise.MultiTenancy.Dto;

namespace MyABPPractise.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

