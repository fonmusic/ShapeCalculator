using ShapesOfThings;

namespace MindboxTestTask;
class Program
{
    static void Main(string[] args)
    {
        var figure1 = new Circle(5);
        Console.WriteLine(figure1.CalculateArea());

        var figure2 = new Triangle(3, 4, 5);
        Console.WriteLine(figure2.IsRightTriangle);
        Console.WriteLine(figure2.CalculateArea());
    }
}
