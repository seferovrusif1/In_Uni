using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_init_record.Models
{
    internal class Lesson
    {
        public string Name { get; set; }
        _nameList
        public string[] NameList { get; set; }


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
            return NameList;
        }
        public void Print()
        {
            foreach (var item in NameList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
