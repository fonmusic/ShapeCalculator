using ShapesOfThings;
namespace Test.Shapes;

[TestClass]
public class UnitTestOfShapes
{
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
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double expectedArea = 6;
        Shape triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double actualArea = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void Triangle_IsRightTriangle_WithValidSides_ReturnsTrue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Shape triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = ((Triangle)triangle).IsRightTriangle;

        // Assert
        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    public void Triangle_IsRightTriangle_WithInvalidSides_ReturnsFalse()
    {
        // Arrange
        double sideA = 2;
        double sideB = 3;
        double sideC = 4;
        Shape triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = ((Triangle)triangle).IsRightTriangle;

        // Assert
        Assert.IsFalse(isRightTriangle);
    }
}