using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Domain.Common;
using UserHub.Domain.Models;

namespace UserHub.Domain.Repositories
{
    public interface IPersonRepository : IRepository
    {
        Task<PersonModel> InsertAsync(PersonModel model);
        Task<PersonModel?> UpdateAsync(PersonModel model);
        Task DeleteAsync(PersonModel model);
        Task<PersonModel> GetByIdAsync(int indentify);
        Task<PersonModel> GetByEmailAsync(string email);
        Task<bool> IsEmailDuplicated(string email);
    }
}
