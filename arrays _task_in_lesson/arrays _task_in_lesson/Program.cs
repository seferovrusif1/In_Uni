namespace arrays__task_in_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////TASK
            //int[] nums = { 14, 21, 7, 8,6, 2, 16, 9 };
            //int a = 8;
            //int istrue = -1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]==a)
            //    {
            //        istrue =   i;
            //        break;
            //    }
            //}
            //Console.WriteLine(istrue);


            //string word = "Hello";
            //char letter = 'b';
            //bool isTrue = false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        isTrue = true;
            //    }
            //}
            //Console.WriteLine(isTrue);




            string sentence = " hi Hello asd asd";
            string word = "hti";

            string isTrue = "false";
            int t = 0;
            for (int i = 0; i < sentence.Length-word.Length; i++)
            {
                t = i;
                for(int j = 0; j < word.Length; j++)
                {
                    if (sentence[t] == word[j])
                    {
                        t += 1;
                    }
                    else
                    {
                        break;
                    }
                    if (j == word.Length - 1)
                    {
                        isTrue = "true";
                    }
                }
                if (isTrue=="true")
                {
                    break;
                }

            }
            Console.WriteLine(isTrue);

        }
    }
}