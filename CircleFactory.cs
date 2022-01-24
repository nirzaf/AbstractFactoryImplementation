namespace StackMemory;

public class CircleFactory : ShapeFactory, IShapeFactory
{
    private double _radius;

    public virtual Circle DrawShape(double radius)

    {
        _radius = radius;
        return new Circle(_radius);
    }

    public double GetArea()
    {
        return DrawShape(_radius).GetArea();
    }

    public double GetCircumference()
    {
        return DrawShape(_radius).GetCircumference();
    }
}