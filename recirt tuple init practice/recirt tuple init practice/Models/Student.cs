using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace recirt_tuple_init_practice.Models
{
    internal record Student()
    {
        
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        //public Student(string Name,string SurName,int Age)
        //{
        //    this.Name = Name;
        //    this.SurName = SurName;
        //    this.Age = Age;
        //}

        public void User()
        {
            Console.WriteLine($"{Name+SurName} {Age}");
        }

        public Tuple<string, string, int> GetStudent()
        {
            var employee = Tuple.Create("Sd", "sds", 5);
            return employee;
        }

    }
}
