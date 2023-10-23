using Accesmodifierpractice.Models;

namespace Accesmodifierpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person a = new Person();
            a.Name = "Rusif";
            a.Surname = "Safarov";
            a.Age = 20;
            a.BirthDay = DateTime.Now;
            a.PhoneNumber = " +994506666666";
            //Console.WriteLine($"Name: {a.GetName()}\nSurname: {a.GetSurname()}\nBirthday: {a.GetBirthDay()}\nAge: {a.GetAge()}");
            a.GetFullInfo();

        }
       
             
    }
}
