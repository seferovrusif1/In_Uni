namespace quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            TAsk1

            //for (; true;)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    int a = 0;
            //    int b = n;

            //        bool istrue = true;
            //        for (; istrue = true;)
            //        {
            //            // Console.WriteLine(a + "  " + n);
            //            a = (a * 10) + (n % 10);
            //            n = n / 10;

            //            if (n == 0)
            //            {
            //                istrue = false;
            //                break;
            //            }
            //        }
            //        Console.WriteLine(b == a);
            //}

            ////for (int i = 1; i < n.Length + 1; i++)
            ////{
            ////    a += n[n.Length - i];
            ////}
            ////if (a == n)
            ////{
            ////    Console.WriteLine(true);
            ////}
            ////else
            ////{
            ////    Console.WriteLine(false);
            ////}





            //TAsk 2


            //int[] c = { 0, 1, 2,27,54,2, 3, 4, 5 };
            //int cmax = 0;
            //int cmin = 0;
            //for (int i = 1; i < c.Length; i++)
            //{
            //    if (c[cmax] < c[i])
            //    {
            //        cmax = i;
            //    }
            //    if (c[cmin] > c[i])
            //    {
            //        cmin = i;

            //    }
            //}
            //c[cmin] = c[cmin] + c[cmax];
            //c[cmax] = c[cmin] - c[cmax];
            //c[cmin] = c[cmin] - c[cmax];
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}


            //////task 3 
          

            for (; true;)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int m = n;
                int l = n / 10;
                int a = 0;
                int b = 0;
                bool isokay = false;
                for (; true;)
                {
                    a = m % 10;
                    m = m / 10;
                    if (isokay)
                    {
                        break;
                    }

                    if (m == 0)
                    {
                        break;
                    }
                    for (; true;)
                    {
                        b = l % 10;
                        if (a == b)
                        {
                            isokay = true;
                            break;
                        }
                        if (l == 0)
                        {
                            break;
                        }
                        b = l % 10;
                        l = l / 10;
                    }
                    l = m / 10;
                }
                Console.WriteLine(isokay);
            }





            //////////////////////////int m = n;
            //////////////////////////int a = 0;
            //////////////////////////bool istrue = true;
            //////////////////////////for (; istrue = true;)
            //////////////////////////{
            //////////////////////////    m = m / 10;
            //////////////////////////    a += 1;
            //////////////////////////    if (m == 0)
            //////////////////////////    {
            //////////////////////////        istrue = false;
            //////////////////////////        break;
            //////////////////////////    }
            //////////////////////////}
            //////////////////////////int[] arr = new int[a];
            //////////////////////////m = n;
            //////////////////////////int k = n;
            //////////////////////////int t = 0;
            //////////////////////////for (int i = 0; istrue = true; i++)
            //////////////////////////{
            //////////////////////////    t = m % 10;
            //////////////////////////    arr[i] = t;
            //////////////////////////    m = m / 10;
            //////////////////////////    if (m == 0)
            //////////////////////////    {
            //////////////////////////        istrue = false;
            //////////////////////////        break;
            //////////////////////////    }
            //////////////////////////}
            //////////////////////////for (int i = 0; i < arr.Length; i++)
            //////////////////////////{
            //////////////////////////    Console.WriteLine(arr[i]);
            //////////////////////////}






            //task 4


            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();
            //Console.WriteLine(surname[0]+". "+name);






            //task 5


            //int[] arr = { 9, -3, 2, -5 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if (arr[i]<0)
            //    {
            //        arr[i] = arr[i] * (-1);
            //    }    
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}

        }
    }
}