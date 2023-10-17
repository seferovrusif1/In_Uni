using System.Drawing;

namespace praktika_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. elementleri for loopda capa ver

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //2. menfilerin sayini tap

            //int CountOfNegative = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]<0)
            //    {
            //        CountOfNegative++;     
            //    }
            //}
            //Console.WriteLine(CountOfNegative);


            //3. ededi orta tap

            //float sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}

            //Console.WriteLine(sum / nums.Length);

            //4. arraydaki max ve min ededi topla

            //int minDigit = nums[0];
            //int maxDigit = nums[0];

            //for (int i = 1; i < nums.Length; i++)
            //{

            //    if (nums[i] < minDigit)
            //    {
            //        minDigit= nums[i];
            //    }
            //    if (nums[i] > maxDigit)
            //    {
            //        maxDigit = nums[i];
            //    }
            //}
            //Console.WriteLine(maxDigit+minDigit);

            //5.
            int[] nums = {  320, 2500, -6, 60, 100, 6, 200, 50 };
            int stMaxDigit = int.MinValue;
            int ndMaxDigit = int.MinValue;
            int index = 0;        
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > stMaxDigit)
                {
                    index = i;
                }
            }
            Console.WriteLine("index" + index);
            for (int i = 1; i < nums.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else if (nums[i] > ndMaxDigit)
                {
                    ndMaxDigit = nums[i];
                }
            }
            Console.WriteLine(ndMaxDigit);


            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i - 1] > stMaxDigit)
            //    {
            //        stMaxDigit = nums[i - 1];
            //    }
            //    if (nums[i] > ndMaxDigit)
            //    {
            //        ndMaxDigit = nums[i];
            //    }
            //    if (stMaxDigit < ndMaxDigit)
            //    {
            //        ndMaxDigit = stMaxDigit;
            //    }
            //}
            //Console.WriteLine(ndMaxDigit);


            // special task 40 point




            //bool isokay = true;
            //do
            //{
            //    Console.WriteLine("10-20 arasireqemdaxil edin");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 20 && num >10) 
            //    {
            //            if (num%2==0)
            //            {
            //                Console.WriteLine("cut ededdir");
            //            }
            //            else
            //            {
            //                Console.WriteLine("tek ededdir");
            //            }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");
            //        Console.WriteLine("DAvam etmek istiyrsense Y,y,Yes daxil edin");
            //        string isyes = Convert.ToString(Console.ReadLine());
            //        if (isyes == "Y" || isyes == "y" || isyes == "Yes")

            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine("DAvam etmek istemirsense N,n,No daxil edin");
            //    string isno = Console.ReadLine();
            //    if (isno == "N" || isno == "n" || isno == "No" ) 
            //    {
            //        isokay=false;
            //    }
            //    else
            //    {
            //        isokay = true;

            //    }
            //    //Console.Clear();
            //} while (isokay==true);








        }
    }
}