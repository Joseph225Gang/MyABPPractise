using AutoMapper;
using MyABPPractise.Authorization.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPPractise.Persons.Dto
{
    public class PersonMapProfile : Profile
    {
        public PersonMapProfile()
        {
            CreateMap<PersonDto, Person>();

            CreateMap<CreatePersonDto, Person>();
        }
    }
}
