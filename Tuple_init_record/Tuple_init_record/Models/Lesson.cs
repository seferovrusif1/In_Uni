using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_init_record.Models
{
    internal class Lesson
    {
        private string[] _nameList=new string[0];
        public string Name { get; set; }
        public string[] NameList { get => _nameList; set { _nameList = NameList; } }


        public void Add(params string[] number)
        {
            foreach (var item in number)
            {
                Array.Resize(ref _nameList, NameList.Length + 1);
                NameList[NameList.Length - 1] = item;
            }

        }

        public void Add(string number)
        {
            Array.Resize(ref _nameList, _nameList.Length + 1);
            _nameList[_nameList.Length - 1] = number;

        }
        public void Get(int index)
        {
            for (int i = 0; i < _nameList.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine(_nameList[i]);

                }
            }
        }
        public string[] GetAll()
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
