using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPPractise.Persons.Dto
{
    public class PagedPersonResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
