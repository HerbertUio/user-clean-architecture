using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Domain.Common;

namespace UserHub.Domain.Exceptions
{
    public class InvalidBirthdateException : DomainException
    {
        public InvalidBirthdateException() : base("Invalid birthdate")
        {
        }
    }
}
