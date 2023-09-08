namespace ServiceA.Tests;

public class CommonTests
{
    [Fact]
    public void SumTest()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<MathController>>();
        var controller = new MathController(mockLogger.Object);

        // Act
        var result = controller.Sum(2, 3);

        // Assert
        Assert.Equal(5, result.Sum);
    }

    [Fact]
    public void MultiplyTest()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<MathController>>();
        var controller = new MathController(mockLogger.Object);

        // Act
        var result = controller.Multiply(2, 3);

        // Assert
        Assert.Equal(6, result.Mult);
    }
}