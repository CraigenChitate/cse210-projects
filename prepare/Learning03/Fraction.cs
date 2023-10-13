
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor with no parameters, initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter for the top, denominator initialized to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and setter for the bottom value
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction representation as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
