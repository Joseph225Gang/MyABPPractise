using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPPractise.Persons.Dto
{
    public class PersonEditDto : EntityDto<int>
    {
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
