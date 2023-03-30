using ShapesOfThings;
namespace Test.Shapes;

[TestClass]
public class UnitTestOfShapes
{
    private const double Tolerance = 0.0001; // constant to eliminate the problems of comparing double values

    [TestMethod]
    public void Circle_AreaCalculation_IsCorrect()
    {
        // Arrange
        double radius = 5;
        double expectedArea = Math.PI * radius * radius;
        Shape circle = new Circle(radius);

        // Act
        double actualArea = circle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void Triangle_AreaCalculation_IsCorrect()
    {
        // Arrange
        double sideA = 2;
        double sideB = 3;
        double sideC = 4;
        double expectedArea = 2.904738;
        Shape triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double actualArea = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea, Tolerance);
    }

    [TestMethod]
    public void Triangle_IsRightTriangle_ReturnsTrue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle; 

        // Assert
        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    public void Triangle_IsRightTriangle_ReturnsFalse()
    {
        // Arrange
        double sideA = 2;
        double sideB = 3;
        double sideC = 4;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle;

        // Assert
        Assert.IsFalse(isRightTriangle);
    }

    [TestMethod]
    public void Valid_Triangle_DoesNotThrowException()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        // Act
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Assert
        Assert.IsNotNull(triangle);
    }

    [TestMethod]
    public void Invalid_Triangle__ThrowsArgumentException()
    {
        // Arrange
        double sideA = 1;
        double sideB = 1;
        double sideC = 3;

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
}