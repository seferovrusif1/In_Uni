using inheritance_practice.Models;

namespace inheritance_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car x001 = new Car();
            x001.Brand = "BMW";
            x001.Model = "M4";
            x001.Colour = "Dark Blue";
            x001.ProducedYear = 2015;
            x001.MaxSpeed = 250;
            x001.DoorCount = 4;
            x001.Type = "Sedan";
       
        
            Plane x002 = new Plane();
            x002.Brand = "Azal";
            x002.Model = "S234";
            x002.Colour = "White";
            x002.ProducedYear = 2018;
            x002.MaxSpeed = 320;
            x002.SeatCount = 200;
            x002.HasBusinessClass = true;

            Console.WriteLine(x001.GetMaximumSpeed());
            Console.WriteLine(x002.GetMaximumSpeed());

            Vehichle[] vehichles = { x001, x002 };
            foreach (var item in vehichles)
            {
                Console.WriteLine(item.ProducedYear);
            }




            //-----------------
            string a = "efdwesdddd";
            Console.WriteLine(a.IndexOf("we"));
            int indexOfChar=0;
            string searchingSymbol = "we" ;
            if (searchingSymbol.Length==1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == Convert.ToChar(searchingSymbol))
                    {
                        indexOfChar = i;
                        Console.WriteLine(indexOfChar);
                        break;
                    }
                }
            }
            else if(searchingSymbol.Length> 1)
            {
                bool isOkey=false;
                for (int i = 0; i < a.Length; i++)
                {
                    if (!isOkey)
                    {
                        int checkCount = 0;
                        for (int j = 0; j < searchingSymbol.Length; j++)
                        {
                            if (a[i] == searchingSymbol[j])
                            {
                                checkCount++;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                            if (checkCount == searchingSymbol.Length)
                            {
                                Console.WriteLine(i-j-1);
                                isOkey = true;
                                break;
                            }

                        }
                    }

                }
                if (!isOkey)
                {
                    Console.WriteLine(-1);
                }
            }


            ////-------
            //Console.WriteLine(a.LastIndexOf("d"));
            //int lastIndexOfChar = 0;
            //char lastSearchingSymbol = 'd';
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == searchingSymbol)
            //    {
            //        lastIndexOfChar = i;
                    
            //    }
            //}
            //Console.WriteLine(lastIndexOfChar);
            
            


        }
    }
}