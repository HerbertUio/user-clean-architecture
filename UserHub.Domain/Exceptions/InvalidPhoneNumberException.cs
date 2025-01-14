using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Domain.Common;

namespace UserHub.Domain.Exceptions
{
    public class InvalidPhoneNumberException : DomainException
    {
        public InvalidPhoneNumberException() : base("Invalid phone number")
        {
        }
    }
}
