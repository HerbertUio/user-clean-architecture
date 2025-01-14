using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Application.Common;

namespace UserHub.Application.Exceptions
{
    public class DuplicatedEmailException : AppLayerException
    {
        public DuplicatedEmailException() : base("The email is duplicated. ")
        {
        }

    }
}
