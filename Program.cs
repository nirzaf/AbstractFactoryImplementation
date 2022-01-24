using StackMemory;

CircleFactory spf = new();

Console.WriteLine($" Area of the circle : { spf.DrawShape(5).GetArea()}");
Console.WriteLine($" Circumference of the circle : { spf.DrawShape(5).GetCircumference()}");



namespace StackMemory
{
    public abstract class ShapeFactory
    {
        public abstract Circle DrawShape(double radius);
    }


    public class CircleFactory : ShapeFactory
    {
        //public Circle GetCircleObject(double radius)
        //{
        //    return new Circle(radius);
        //}

        public override Circle DrawShape(double radius)
        {
            return new Circle(radius);
        }
    }
}