using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_modifier_sinifde_task_tekrar
{
    internal class Notebook:Product
    {
        private string _brand;
        private string _model;
        private int _ram;
        private  int _storage;
        public string Brand 
        { 
            get=>_brand; 
            set
                {
                if (value.Length>2 && value.Length < 31)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Ad duzgun deyil");
                }
                }
        }
        public string Model
        {
            get => _model;
            set
            {
                if (value.Length > 2 && value.Length < 31)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Ad duzgun deyil");
                }
            }
        }
        public int Ram 
        {
            get=>_ram; 
            set 
            {
                if (value < 128 && value > 0)
                {
                    _ram = value;
                }
            } 
        }
        public int Storage
        {
            get => _storage;
            set
            {
                if (value > 0)
                {
                    _storage = value;
                }
            }
        }

        public Notebook(string model,int count,int price):base(count,price)
        {
            _model = model;
        }



    }
}
