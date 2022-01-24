public class Rectangle
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double GetArea()
    {
        return _length * _width;
    }

    public double GetCircumference()
    {
        return 2 * (_length + _width);
    }
}