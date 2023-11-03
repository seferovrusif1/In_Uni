using Casting_practice_lesson_taks.Models;

namespace Casting_practice_lesson_taks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car masin1 = new Car(10);
            Car masin2 = new Car(11);

            Console.WriteLine(masin2 < masin1);
            Console.WriteLine(masin2 > masin1);



            //Vehichle masin = new Car();
            //Vehichle avtobus = new Bus();
            //Vehichle[] vehichles= { masin, avtobus };
            //foreach (var item in vehichles)
            //{
            //    if (item is Car c)
            //    {
            //        item.Drive();
            //    }
            //    else if(item is Bus b)
            //    {

            //        b.Drive();
            //    }
            //}
            //foreach (var item in vehichles)
            //{
            //    if ((item as Car  ) is not null)
            //    {
            //        item.Drive();
            //    }
            //    else if ((item as Bus) is not null)
            //    {
            //        item.Drive();
            //    }

            //}

        }

    }
}