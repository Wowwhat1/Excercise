namespace ConsoleApp2;

public class Dice
{
    // Field
    private int _side;
    // Property
    public int Side
    {
        get { return _side; }
        set { if (_side > 0) _side = value;}
    }

    public int Roll()
    {
        Random rd = new Random();
        return rd.Next(1, _side + 1);
    }
}