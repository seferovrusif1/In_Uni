using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class StoreItem
    {
        public Book book { get; set; }
        public int StockCount { get; set; }
    }
}
