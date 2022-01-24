using StackMemory;

CircleFactory circleFactory = new();
RectangleFactory rectangleFactory = new();

Console.WriteLine($" Area of the circle : { circleFactory.DrawShape(5).GetArea()}");
Console.WriteLine($" Circumference of the circle : { circleFactory.DrawShape(5).GetCircumference()}");

Console.WriteLine($" Area of the rectangle : { rectangleFactory.DrawShape(5, 15).GetArea()}");
Console.WriteLine($" Circumference of the circle : { rectangleFactory.DrawShape(5, 15).GetCircumference()}");

