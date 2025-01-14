using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Domain.Models;
using UserHub.Domain.Repositories;

namespace Application.Test.Mock
{
    internal class PersonRepository : IPersonRepository
    {
        public Task DeleteAsync(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> GetByIdAsync(int indentify)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> InsertAsync(PersonModel model)
        {
            return Task.FromResult(model);
        }

        public Task<bool> IsEmailDuplicated(string email)
        {
            return Task.FromResult(false);
        }

        public Task<PersonModel?> UpdateAsync(PersonModel model)
        {
            throw new NotImplementedException();
        }
    }
}
