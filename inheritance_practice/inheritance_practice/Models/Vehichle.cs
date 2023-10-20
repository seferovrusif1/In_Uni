using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_practice.Models
{
    internal class Vehichle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int ProducedYear;
        public int MaxSpeed;

        public string GetMaximumSpeed()
        {
            return $"{Brand}, {Model} can run max speed {MaxSpeed}";
        }


    }
}
