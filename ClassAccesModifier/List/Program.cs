using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList a = new IntList();

            a.Add(3);
            a.Add(1, 2, 3);
            a.Get(1);
            Console.WriteLine(a.GetAll());
            a.Print();


            //while (true)
            //{
            //    Console.WriteLine("Add:-0\nadd params:1\nget index:2\nget all:3\nprint:4");
            //    string b= Console.ReadLine();
            //    switch (b)
            //    {
            //        case "0":

            //            break;
            //        case "1":
            //            break;
            //        case "2":
            //            break;
            //        case "3":
            //            break;
            //        case "4":
            //            break;
            //    }
            //}
        }
    }
}