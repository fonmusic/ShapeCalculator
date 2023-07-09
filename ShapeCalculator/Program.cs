using ShapeCalculatorLibrary;

var figure1 = new Circle(5);
Console.WriteLine(figure1.CalculateArea());

var figure2 = new Triangle(3, 4, 5);
Console.WriteLine(figure2.IsRightTriangle);
Console.WriteLine(figure2.CalculateArea());

var figure3 = new Triangle(2, 3, 4);
Console.WriteLine(figure3.IsRightTriangle);
Console.WriteLine(figure3.CalculateArea());
