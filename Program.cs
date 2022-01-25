using Microsoft.VisualBasic;
using StackMemory;

//CircleFactory circleFactory = new();
//RectangleFactory rectangleFactory = new();

//Console.WriteLine($" Area of the circle : { circleFactory.DrawShape(5).GetArea()}");
//Console.WriteLine($" Circumference of the circle : { circleFactory.DrawShape(5).GetCircumference()}");

//Console.WriteLine($" Area of the rectangle : { rectangleFactory.DrawShape(5, 15).GetArea()}");
//Console.WriteLine($" Circumference of the circle : { rectangleFactory.DrawShape(5, 15).GetCircumference()}");

Tuple<string, string> Employee = new Tuple<string , string>("Fazrin", "Kandy");


Employee emp1 = new Employee();

emp1.Person();

Console.WriteLine("Name : {0}, Address: {1}, Age: {2}", emp1.Person().Item1 , emp1.Person().Item2 , emp1.Person().Item3);

Location a = new(20, 20);  
Location b = a;  
a.x = 100;
Console.WriteLine(b.x);

Person p1 = new Person
{
    Name = ""
};