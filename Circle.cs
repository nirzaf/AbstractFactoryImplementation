public class Circle
{
    private readonly double _radius;
    private const double Pie = 3.14;

    public Circle(double radius)
    {
        _radius = radius;
    }


    public double GetCircumference()
    {
        return 2 * Pie * _radius;
    }

    public double GetArea()
    {
        return Pie * _radius * _radius;
    }
}