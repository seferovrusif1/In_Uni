﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceTask.Models
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public uint PageCount { get; set; }

        public override void Sell()
        {
            if (Count > 0)
            {
            Count--;
            TotalInCome+=Price;
            Console.WriteLine("satildi!");
            }
            else
            {
                Console.WriteLine("Bitmisdir!");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine(this);
        }


        public override string ToString()
        {
            return $"\n Book Id: {Id}\nBook Name: {Name}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}\nBook Price: {Price}\nBook Count: {Count}\nTotalInCome: {TotalInCome}";
        }

























    }
}
