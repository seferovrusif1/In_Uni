using AAbstrak_interface___.Model;

namespace AAbstrak_interface___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure rec = new Rectangular(12, 12);
            Square sq = new Square(1);
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("\n1. Square\n2. Rectangular\n0. Quit\n");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "0":
                        isContinue = false;
                        break;
                    case "1":
                        Console.WriteLine(sq.CalcArea());
                        break;
                    case "2":
                        Console.WriteLine(rec.CalcArea());
                        break;
                }
            }

        }
    }
}