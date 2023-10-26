
using System.Text.RegularExpressions;
using Tuple_init_record.Models;

namespace Tuple_init_record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Group a840 = new Models.Group(4, "MIT");
            Student r = new Student()
            {
                Name = "sd",
                SurName = "sd",
                Age = 2,
                Group = a840,
                Result = {}
            };
            Lesson l = new Lesson {Name= "a"};
            Result res = new Result { Lesson = l ,Grade=5};


        }
    }

}