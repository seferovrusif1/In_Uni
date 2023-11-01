using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Basket
    {
        public List<BasketItem> basketItems {get;set;}
        public int TotalCount { get; set; }
        public string DiscountCode{ get; set; }
    }
}
