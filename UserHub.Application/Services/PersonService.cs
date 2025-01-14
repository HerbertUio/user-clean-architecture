using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Domain.Exceptions;
using UserHub.Domain.Models;
using UserHub.Domain.Repositories;

namespace UserHub.Application.Services
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IEmailValidatorProvider _emailValidatorProvider;

        public PersonService(IPersonRepository personRepository, IEmailValidatorProvider emailValidatorProvider)
        {
            _personRepository = personRepository;
            _emailValidatorProvider = emailValidatorProvider;
        }

        public async Task<PersonModel> CreatePerson(PersonModel personModel)
        {

            if (await _personRepository.IsEmailDuplicated(personModel.Email))
            {
                throw new DuplicatedEmailException();

            }

            if (!await _emailValidatorProvider.IsEmailValid(personModel.Email))
            {
                throw new InvalidEmailException();

            }

            return await _personRepository.InsertAsync(personModel);
        }

    }
}

