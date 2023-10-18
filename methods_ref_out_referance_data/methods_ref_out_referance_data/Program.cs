namespace methods_ref_out_referance_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            for (;true;)
            {
                Console.WriteLine("Element elave etmek istiyrsizse y yaz:");
                string y = Console.ReadLine();
                if (y == "y")
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    Console.WriteLine("Elementi daxil edin:");
                    arr[arr.Length - 1] = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            //int a = 8;
            //int b = 9;
            //Exchange(ref a, ref b);
            //Console.WriteLine("a: "+ a+ "     b: "+b);

        }



        static void Exchange(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

    }
}