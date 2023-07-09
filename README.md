# Shape Calculator

This project is a shape calculator library that provides classes for calculating the areas of different geometric shapes. It includes the following shapes: Circle and Triangle. The library is implemented in C# and follows the .NET standard.

## Shapes

### Circle
The **Circle** class represents a circle shape. It implements the **IShape** interface and provides methods to calculate the area of the circle.

#### Constructor

- **Circle(double radius)**: Initializes a new instance of the **Circle** class with the specified radius.
#### Methods

- **CalculateArea()**: Calculates and returns the area of the circle based on its radius.
### Triangle
The **Triangle** class represents a triangle shape. It implements the **IShape** interface and provides methods to calculate the area and determine if it is a right triangle.

#### Constructor
- **Triangle(double sideA, double sideB, double sideC)**: Initializes a new instance of the Triangle class with the specified side lengths. It throws an ArgumentException if the given side lengths do not form a valid triangle.

#### Properties
- **IsRightTriangle**: Gets a boolean value indicating whether the triangle is a right triangle or not.

#### Methods
- **CalculateArea()**: Calculates and returns the area of the triangle based on its side lengths using Heron's formula.
## Console Application

The console application demonstrates the usage of the shape calculator library. It includes sample code that creates instances of the **Circle** and **Triangle** classes and calls their respective methods to calculate the areas and determine if the triangle is a right triangle. The results are printed to the console.

## Unit Tests

The project also includes unit tests for the shape calculator library. The tests are implemented using the MSTest framework and verify the correctness of the area calculations and the identification of right triangles. The tests cover different scenarios, including valid and invalid triangles. The tolerance constant is used to account for the precision limitations when comparing double values.

To run the unit tests, execute the test methods defined in the UnitTestOfShapes class.