using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Application.Providers;

namespace Application.Test.Mock
{
    internal class EmailValidatorProvider : IEmailValidatorProvider
    {
        public Task<bool> IsEmailValid(string email)
        {
            return Task.FromResult(true);
        }
    }
}
