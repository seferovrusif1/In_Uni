using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Model
{
    internal abstract class Person
    {
        static int _id { get; set; } = 0;
        public int Id { get ;  }
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }
        public virtual void FulName()
        {
            Console.WriteLine($"{Name} {SurName}");
        }
        public Person()
        {
            _id++;
            Id = _id;
        }
       
    }
}
