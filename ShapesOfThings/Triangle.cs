namespace ShapesOfThings;
public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    private const double Tolerance = Double.Epsilon; // constant to eliminate the problems of comparing double values
    public bool IsRightTriangle
    {
        get
        {
            // Sort the sides in ascending order
            double[] sides = new double[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            // Check if the sum of the squares of the two sides of the triangle is equal to the square of the third side
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < Tolerance;
        }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("Invalid triangle sides");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    private static bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB);
    }

    //Heron's formula where p - half of the perimeter
    public double CalculateArea()
    {
        double p = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }
}