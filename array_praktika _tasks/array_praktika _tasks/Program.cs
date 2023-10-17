namespace array_praktika__tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (; true;)
            //{
                //string word = Console.ReadLine();
                //string word2 = "";
                //int i = 0;
                //int n = word.Length;
                //if (word[0] == ' ')
                //{
                //    i = 1;
                //}
                //else if (word[word.Length - 1] == ' ')
                //{
                //    n -= 1;
                //}
                //for (; i < n; i++)
                //{
                //    word2 += word[i];
                //}
                //Console.WriteLine(word2 +"  yeni sozun uzunluqu: "+word2.Length);


                //TAsk 2
                //Console.WriteLine("N-i sonrada M-i daxil edin: ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int m = Convert.ToInt32(Console.ReadLine());
                //for (int i = n; i < m; i++)
                //{
                //    if (i < 0)
                //    {
                //        Console.WriteLine("Menfi " + i + " ve Musbet " + i * -1);

                //    }
                //    else if (i > 0)
                //    {
                //        Console.WriteLine("Musbet " + i + " ve Menfi" + i * -1);
                //    }
                //    else
                //    {
                //        Console.WriteLine(0);
                //    }

                //Task 3
                //string word = Console.ReadLine();
                //string newWord = "";

                //for (int i = 1; i < word.Length + 1; i++)
                //{
                //    newWord += word[word.Length - i];
                //}
                //Console.WriteLine(newWord);

                //TAsk 4

                int[] array = { 9, 13, 234,13, 45, 9,13 };
                string dublicat = "";
                for (int i = 0;  i< array.Length; i++)
                {
                    
                    int t = array[i];
                    int tcount = 0;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            tcount += 1;
                        }

                    }
                    if (tcount > 1)
                    {
                        Console.WriteLine(t + " ededinden " + tcount + "eded var");
                    }
                }

            }
            }
        }
    


