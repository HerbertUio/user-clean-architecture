using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Application.Common;

namespace UserHub.Application.Exceptions
{
    public class InvalidEmailException : AppLayerException
    {
        public InvalidEmailException() : base("The email is not valid. ")
        {
        }
    }
}

