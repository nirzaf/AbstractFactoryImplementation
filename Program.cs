using StackMemory;

CircleFactory circleFactory = new();

Console.WriteLine($" Area of the circle : { circleFactory.DrawShape(5).GetArea()}");
Console.WriteLine($" Circumference of the circle : { circleFactory.DrawShape(5).GetCircumference()}");



namespace StackMemory
{

    public abstract class ShapeFactory 
    {
        public abstract Circle DrawShape(double radius);
    }


    public class CircleFactory : ShapeFactory, IShapeFactory
    {
        private double _radius;

        public override Circle DrawShape(double radius)
        {
            _radius = radius;
            return new Circle(radius);
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
}

public interface IShapeFactory
{
    double GetArea();

    double GetCircumference();
}