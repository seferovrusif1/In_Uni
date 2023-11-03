using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_practice_lesson_taks.Models
{
    internal class Bus : Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("This is a bus method.");
        }
    }
}
