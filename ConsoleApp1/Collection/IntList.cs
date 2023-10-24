using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class IntList { 
        public int[] arr = new int[0];




    public void Add(params int[] number)
    {
        foreach (var item in number)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

    }







    public void Add(int number)
    {
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = number;

    }
    public void Get(int index)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == index)
            {
                Console.WriteLine(arr[i]);

            }
        }
    }
    public int[] GetAll()
    {
        return arr;
    }
    public void Print()
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

}
}




















}
