using Abp.Application.Services;
using MyABPPractise.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPPractise.Persons
{
    public interface IPersonAppService : IAsyncCrudAppService<PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>
    {
    }
}
