using ShapeCalculatorLibrary;

var figure1 = new Circle(5);
Console.WriteLine($"Area of the circle: {figure1.CalculateArea()}");

var figure2 = new Triangle(3, 4, 5);
Console.WriteLine($"Is figure2 a right triangle? - {figure2.IsRightTriangle}!");
Console.WriteLine($"Area of figure2: {figure2.CalculateArea()}");

var figure3 = new Triangle(2, 3, 4);
Console.WriteLine($"Is figure3 a right triangle? - {figure3.IsRightTriangle}!");
Console.WriteLine($"Area of figure3: {figure3.CalculateArea()}");
