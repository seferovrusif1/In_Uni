using practiceTask.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace practiceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            Book kitab = new Book()
            {
                AuthorName = "sd",
                Name = "sdsd",
                PageCount = 11,
                Price = 11,
                Count = 5
            };
            Book kitabb = new Book()
            {
                AuthorName = "sd",
                Name = "sdsd",
                PageCount = 19,
                Price = 15,
                Count = 3
            };
            Book kitsabb = new Book()
            {
                AuthorName = "sd",
                Name = "sdsd",
                PageCount = 10,
                Price = 10,
                Count = 5
            };
            kitab.ShowInfo();
            lib.AddBook(kitab);
            lib.AddBook(kitabb);
            lib.AddBook(kitsabb);
            lib.GetAllBooksId();
            lib.GetBookById(1);
            kitabb.Sell();
            kitabb.Sell();
            lib.GetBookById(1);







            //bool iscontinue = true;
            //while (iscontinue)
            //{

            //    Console.WriteLine($"\n0:Add a Book\n1: Sell a Book\n2:See all Book Id \n3: GetBookById\n4: \n5: Show Info\n6: End\n");
            //    string a = Console.ReadLine();

            //    switch (a)
            //    {
            //        case "0":
            //            kitab = new Book()
            //            {
            //                AuthorName = Console.ReadLine(),
            //                Name = Console.ReadLine(),
            //                PageCount = Convert.ToUInt32(Console.ReadLine()),
            //                Price = Convert.ToDecimal( Console.ReadLine()),
            //                Count = Convert.ToInt32(Console.ReadLine()),
            //            };
            //            break;

            //        case "1":
            //            Console.WriteLine();
            //            break;

            //        case "2":
            //            break;

            //        case "3":
            //            break;
            //        case "4":
            //            break;
            //        case "5":
            //            break;
            //        case "6":
            //            iscontinue = false;
            //            break;
            //    }
            //}
        }
    }
}