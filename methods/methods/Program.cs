namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 2, 35, 34 };
            //connect(array1, 1, 2, 3);
            Console.WriteLine(Min(Array1));
            Console.WriteLine(Hasil(Array1));
            Console.WriteLine(Pow(3, 0));
            Console.WriteLine(avg(Array1));
        }


        static void connect(int[] array1, params int[] array2)
        {

            int[] newarray = new int[array1.Length + array2.Length];

            for (int i = 0; i < newarray.Length; i++)
            {
                if (i < array1.Length)
                {
                    newarray[i] = array1[i];
                }
                else
                {
                    newarray[i] = array2[i - array1.Length];
                }
            }
            foreach (var num in newarray)
            {
                Console.WriteLine(num);
            }

        }


        //static void connect(int[] array1, params int[] array2)
        //{

        //    int[] newarray = new int[array1.Length + array2.Length];
        //    int i = 0;

        //    for (; i < array1.Length; i++)
        //    {
        //        newarray[i] = array1[i];
        //    }
        //    for (; i > array1.Length && i < newarray.Length; i++)
        //    {
        //        newarray[i] = array2[i - array1.Length];

        //    }
        //    foreach (var num in newarray)
        //    {
        //        Console.WriteLine(num);
        //    }

        //}



        static int Min(params int[] Array1)
        {
            int Min = Array1[0];
            foreach (var Item in Array1)
            {
                if (Min > Item)
                {
                    Min = Item;
                }
            }
            return Min;
        }



        static int Max(params int[] Array1)
        {
            int Max = Array1[0];
            foreach (var Item in Array1)
            {
                if (Max < Item)
                {
                    Max = Item;
                }
            }
            return Max;
        }




        static int Hasil(params int[] Array1)
        {
            return Max(Array1) * Min(Array1);
        }




        static int Pow(int n, int m)
        {
            int l = 1;
            for (int i = 0; i < m; i++)
            {
                l = l * n;
            }
            return l;
        }


        static int avg(params int[] Array1)
        {
            int Sum = 0;
            foreach (var item in Array1)
            {
                Sum += item;
            }
            return Sum / Array1.Length;
        }

    




    }
}