using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Models
{
    internal class Developer: Employee
    {
        public string[] KnownLanguages;

        public void WriteCode()
        {
            string languages="";
            foreach (var item in KnownLanguages)
            {
                languages += $"{item} ";
            }
            Console.WriteLine($"{Name} coding {languages}  ");
        }
    }
}
