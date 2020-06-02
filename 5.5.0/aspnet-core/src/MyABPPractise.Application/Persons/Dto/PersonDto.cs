using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyABPPractise.Authorization.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPPractise.Persons.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonDto : EntityDto<int>
    {
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
