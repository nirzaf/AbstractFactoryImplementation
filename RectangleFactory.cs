namespace StackMemory;

public class RectangleFactory : ShapeFactory, IShapeFactory
{
    private double _length;
    private double _width;

    public virtual Rectangle DrawShape(double length, double width)
    {
        _length = length;
        _width = width;

        return new Rectangle(_length, _width);
    }

    public double GetArea()
    {
        return DrawShape(_length, _width).GetArea();
    }

    public double GetCircumference()
    {
        return DrawShape(_length, _width).GetCircumference();
    }
}