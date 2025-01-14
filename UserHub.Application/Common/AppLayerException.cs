using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHub.Application.Common
{
    public class AppLayerException : Exception
    {
        public AppLayerException(string? message) : base(message)
        {
        }
        public AppLayerException(string? message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
