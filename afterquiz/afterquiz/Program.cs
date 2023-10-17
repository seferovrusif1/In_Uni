namespace afterquiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 arraydaki element sayini goster

            int[] array = { 0, 9, 13, 234, 13, 45, 9, 13, 0, 0, 13 };
            int[] Newarray = new int[array.Length]; //yoxladigimiz ededleri tekrar yoxlamamaq ucun 
            for (int i = 0; i < array.Length; i++)
            {

                int t = array[i]; //her defe yoxladiqimiz eded
                int tcount = 0;
                if (Newarray[i] == 0)  //eger ededi yoxlamisiqsa tekrar yoxlamasin
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            Newarray[j] = 1;

                            tcount += 1;
                        }
                    }
                    if (tcount > 1)
                    {
                        Console.WriteLine(t + " ededinden " + tcount + "eded var");
                    }
                }

            }



            ////Task 2 consol write read
            //Console.WriteLine("Arrayin olcusunu daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[n];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("yeni eded daxil edeceksense 'Y','y','Yes','yes' yaz eks halda her hansisa bir sey yaz");
            //    string yes = Console.ReadLine();
            //    if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes")
            //    {
            //        Console.WriteLine("eded daxil edin: ");

            //        nums[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else { break; }
            //}

        }
    }
}