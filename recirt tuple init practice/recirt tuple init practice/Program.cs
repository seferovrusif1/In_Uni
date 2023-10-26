using recirt_tuple_init_practice.Models;
using System.Runtime.InteropServices;

namespace recirt_tuple_init_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student
            {
                Name="Rusif",
                SurName="Safarov",
                Age=20
            };
            a.User();
            var mytpl = Tuple.Create(a.Name, a.SurName, a.Age);
            var myytpl = Tuple.Create("sd", "sdsd", 3);

            (string Name, string SurName, int Age) Rusif=("as","sa",4);
            Console.WriteLine(mytpl);
            Console.WriteLine(Rusif);
            Console.WriteLine(Rusif.Item1);


            Console.WriteLine(a.GetStudent());

        }

        
    }
}