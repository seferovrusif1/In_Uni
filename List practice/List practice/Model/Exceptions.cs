using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Model
{
    internal class Exceptions : Exception
    {
        public Exceptions()
        {
        }

        public Exceptions(string? message) : base(message)
        {
        }
    }
}
