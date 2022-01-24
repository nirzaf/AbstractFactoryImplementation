using StackMemory;

CircleFactory circleFactory = new();
RectangleFactory rectangleFactory = new();

Console.WriteLine($" Area of the circle : { circleFactory.DrawShape(5).GetArea()}");
Console.WriteLine($" Circumference of the circle : { circleFactory.DrawShape(5).GetCircumference()}");

Console.WriteLine($" Area of the rectangle : { rectangleFactory.DrawShape(5, 15).GetArea()}");
Console.WriteLine($" Circumference of the circle : { rectangleFactory.DrawShape(5, 15).GetCircumference()}");



namespace StackMemory
{

    public abstract class ShapeFactory
    {
    }

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
}