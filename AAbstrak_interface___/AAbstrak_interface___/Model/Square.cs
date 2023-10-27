namespace AAbstrak_interface___.Model;

internal class Square:Figure        
{
    private int _side;    
    public int Side { get=>_side; set
        {
            if (value > 0)
            {
                _side = Side;
            }
        }
    }
    public Square(int Side)
    {
        this.Side = Side;
    }
    public override int CalcArea()
    {
        return 3*Side*Side;
    }
}
