namespace RusifLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name=Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());

            //int num= Convert.ToInt32(Console.ReadLine());
            //for (int i =1; i <= num; i++)
            //{

            //    if (i%7==0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}


            //int i = 1;

            //while (i<=num)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //TAsk2
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = 0;
            //for (int i = 1; i <= num1; i++)
            //{

            //    if (i % 15 == 0)
            //    {
            //        num2++;
            //    }
            //}
            //  Console.WriteLine(num2);

            //TAsk3

            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int bignum = num1 % 10;
            //int lastnum = num1 % 10;
            //for (int i = num1; i > 0; i /= 10)
            //{

            //    if (bignum < lastnum)
            //    {
            //        bignum = lastnum;
            //    }
            //    lastnum = i % 10;
            //}
            //Console.WriteLine(bignum);





            ////TAsk 4
            int num1 = Convert.ToInt32(Console.ReadLine());
            bool istrue = true;
            for (int i = 2; i <= num1; i *= 2)
            {
                if (i == num1)
                {
                    istrue = true;

                }
                else
                {
                    istrue = false;

                }
            }

            Console.WriteLine(istrue);






        }
    }
}