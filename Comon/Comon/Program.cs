using Comon.Models;

namespace Comon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int BulletCapacity =0 ;
            int BulletCount=-1 ;
            int EndingTime=0 ;
            Weapon x001= new Weapon(BulletCapacity,BulletCount,EndingTime) ;
            bool iscontinue = true;
            while (iscontinue)
            {
                Console.WriteLine("\ne - Silah editlemek ucun\n0 - Informasiya almaq ucun.\n1 -Shoot metodu ucun.\n2 - Fire metodu ucun.\n3 - GetNeedBulletCount metodu ucun.\n4 - Reloud metodu ucun.\n5 - ChangeFireMode methodu ucun.\n6-Proqrami dayandirmmaq ucun.");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "e":
                        x001.Edit();
                        break;
                    case "0":
                        x001.GetFullInfo();
                        break;
                    case "1":
                        x001.Shoot();
                        break;
                    case "2":
                        x001.Fire();
                        break;
                    case "3":
                        Console.WriteLine(x001.GetNeededBulletCount());
                        break;
                    case "4":
                        x001.Reload();
                        break;
                    case "5":
                        x001.ChangeFireMode();
                        break;
                    case "6":
                        iscontinue = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis input!!");
                        break;
                }
            }
        }

    }
}