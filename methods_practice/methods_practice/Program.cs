namespace methods_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {













            //Console.WriteLine("Tekdir yoxsa cut:    "+IsPair(4));
            //Console.WriteLine("Sade vuruqlari: ");
            //PrimeNum(12);
            //Console.WriteLine(" 4 ve 5");
            //Console.WriteLine(
            //    "     Sum: "+ Sum(4,5)+ 
            //    "     Difference: "+ Difference(4,5)+
            //    "     Multiplication: "+ Multiplication(4,5)+ 
            //    "     Division: "+ Division(4,5));

            //for (; true;)                                     //yoxlamaq daha rahat olsun deyedi bu for, algoritme daxil deyil
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int first = 0, second = 1, third = 0;        //fikrimzde 1-ci ve 2 ci elementleri tuturq sonrada onlari artirib deyismek ucun 3 u elementi istifade edirik 
            //    Console.WriteLine(0);
            //    for (; true;)
            //    {
            //        if (first < x)
            //        {
            //            Console.WriteLine(second);
            //            third = first + second;
            //            first = second;
            //            second = third;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}


            Multiplication(2, 3);
            Multiplication(2, 3, 4);


        }

        static void Multiplication(int a,int b)
        {
            Console.WriteLine("Multiplication 2 num: "+a*b);
        }

        static void Multiplication(int a, int b,int c)
        {
            Console.WriteLine("Multiplication 3 num: " + a * b*c);
        }





        //TAsk1   cut yoxsa tex olmasina bax

        static string IsPair(int n)
        {
            string result = "";
            if (n % 2 == 0)
            {
                result = "Cut ededdir";
            }
            else
            {
                result = "Tek ededdir";
            }
            return result;
        }

        //TAsk2  sade vuruqlara ayir
        static void PrimeNum(int n)
        {
            int i = 2;
            for (; true;)
            {

                if (n == 1)
                {
                    break;
                }
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
        }


        //static void PrimeNum111(int n)
        //{
        //    int i = 2;
        //    int ii = 2;
        //    for (; true;)
        //    {
        //        if (n == 1)
        //        {
        //            break;
        //        }
        //        if (n % i == 0)
        //        {
        //            if (ii != i)
        //            {
        //                Console.WriteLine(ii);

        //            }
        //            n = n / i;

        //        }
        //        else
        //        {
        //            ii = i;

        //            i++;
        //        }

        //    }
        //}


        //Task 3 calc
        static float Sum(float n, float m)
        {
            return n + m;
        }
        static float Difference(float n, float m)
        {
            return n - m;
        }
        static float Multiplication(float n, float m)
        {
            return n * m;
        }
        static float Division(float n, float m)
        {
            return n / m;
        }



    }
}