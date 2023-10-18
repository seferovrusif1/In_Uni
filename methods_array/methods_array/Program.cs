namespace methods_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exchange(1,2,3,4);
        }
        
        static void Exchange( params int[] array)
        {
            int maxI = Max(array);
            int minI = Min(array);
            int c = array[maxI];

            array[maxI] = array[minI];
            array[minI] = c;
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
        static int Max(int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }
            }
            return max;

        }
        static int Min(int[] array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[min] > array[i])
                {
                    min = i;
                }
            }
            return min;

        }
    }
}