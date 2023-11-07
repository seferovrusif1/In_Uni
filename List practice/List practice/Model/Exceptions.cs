using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Model
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException()
        {
        }

        public InvalidNameException(string? message) : base(message)
        {
        }
    }
    internal class InvalidSurNameException : Exception
    {
        public InvalidSurNameException()
        {
        }

        public InvalidSurNameException(string? message) : base(message)
        {
        }
    }
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        {
        }

        public UserNotFoundException(string? message) : base(message)
        {
        }
    }
}
