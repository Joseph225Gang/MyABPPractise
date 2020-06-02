using Abp.Application.Services.Dto;

namespace MyABPPractise.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

