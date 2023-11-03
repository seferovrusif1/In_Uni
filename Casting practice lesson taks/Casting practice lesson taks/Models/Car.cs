using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_practice_lesson_taks.Models
{
    internal class Car : Vehichle
    {
        public Car(int a)
        {
            Price = a;
        }

        public static bool operator >(Car c1, Car c2)
        {
            return c1.Price > c2.Price;
        }
        public static bool operator <(Car c1, Car c2)
        {
            return c1.Price < c2.Price;
        }
        public override void Drive()
        {
            Console.WriteLine("This is a Car method.");
        }
    }
}
