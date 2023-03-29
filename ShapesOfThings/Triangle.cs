namespace ShapesOfThings;
public class Triangle : Shape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public bool IsRightTriangle
    {
        get
        {
            // Sort the sides in ascending order
            double[] sides = new double[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            // Check if the sum of the squares of the two sides of the triangle is equal to the square of the third side
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    //Heron's formula where p - half of the perimeter
    public override double CalculateArea()
    {
        double p = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }
}