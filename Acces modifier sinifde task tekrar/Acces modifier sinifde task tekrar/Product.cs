using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_modifier_sinifde_task_tekrar
{
    internal class Product
    {
        private int _count;
        private int _price;
        public int Count { get; set; }
        public int Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public Product(int count,int price)
        {
            Count = count;
            Price = price;
        }
    }
}
