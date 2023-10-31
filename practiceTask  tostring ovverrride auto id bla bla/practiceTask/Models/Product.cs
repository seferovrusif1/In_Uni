using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practiceTask.Models
{
    internal abstract class Product
    {
        static private int _id=0;

        protected decimal TotalInCome { get; set; }
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
        public Product()
        {
            _id++;
            Id = _id;
        }
    }
}
