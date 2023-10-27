using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface
{
    internal abstract class Bird:Animal
    {
        public  void Fly()
        {
            Console.WriteLine("Flyyy");
        }
    }
}
