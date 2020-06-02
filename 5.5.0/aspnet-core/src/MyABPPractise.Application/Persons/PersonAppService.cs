using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using MyABPPractise.Authorization.Person;
using MyABPPractise.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyABPPractise.Persons
{
    public class PersonAppService : AsyncCrudAppService<Person, PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        private readonly IAbpSession _abpSession;

        public PersonAppService(
                IRepository<Person> repository,
                IAbpSession abpSession
                ) : base(repository)
        {
            _personRepository = repository;
            _abpSession = abpSession;
        }

        public override async Task<PersonDto> CreateAsync(CreatePersonDto input)
        {

            var person = ObjectMapper.Map<Person>(input);
            _personRepository.Insert(person);

            return MapToEntityDto(person);
        }

        public override async Task DeleteAsync(EntityDto<int> input)
        {
            var person = _personRepository.Get(input.Id);
            await _personRepository.DeleteAsync(person);
        }

        public override async Task<PersonDto> UpdateAsync(PersonDto input)
        { 

            var person =  _personRepository.Get(input.Id);
            ObjectMapper.Map(input, person);
            await _personRepository.UpdateAsync(person);
            return MapToEntityDto(person);
        }

        public async Task<ListResultDto<PersonDto>> GetPersons()
        {
            var persons = await _personRepository.GetAllListAsync();
            return new ListResultDto<PersonDto>(ObjectMapper.Map<List<PersonDto>>(persons));
        }
    }
}
