using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface
{
    internal abstract class Fish:Animal
    {
        public virtual void Swim()
        {
            Console.WriteLine("Swimmm");
        }
    }
}
