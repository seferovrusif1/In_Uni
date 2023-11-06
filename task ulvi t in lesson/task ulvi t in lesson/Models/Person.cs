using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_ulvi_t_in_lesson.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurnName { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            Name = name;
            SurnName = surname;
            Age = age;
        }
        public override string ToString()
        {
            return Name + " " + SurnName+" "+Age;
            
        }
    }
}
