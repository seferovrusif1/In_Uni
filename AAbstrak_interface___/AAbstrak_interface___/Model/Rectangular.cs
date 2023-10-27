namespace AAbstrak_interface___.Model
{
    internal class Rectangular:Figure
    {
        private int _width;
        private int _length;
        public int Width { get=> _width; 
            set 
            { 
                if (value > 0)
                    {
                        _width = Width;
                    }
            } 
        }
        public int Length { get=> _length; 
            set
            {
                if (value > 0)
                {
                    _width = Width;
                }
            }
        }


        public Rectangular(int witdh,int length)
        {
            Length = length;
            Width = witdh;
        }
        public override int CalcArea()
        {
            return Length * Width;
        }
    }
}
