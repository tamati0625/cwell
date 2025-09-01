namespace N9_StringCalculator.Tests;

public class StringCalculatorTests
{
    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        var result = calculator.Add("");

        // assert
        Assert.Equal(0, result);
    }


    [Fact]
    public void Add_SingleNumber_ReturnsThatNumber()
    {
        // arrange
        var calculator = new StringCalculator();

        // act
        int result = calculator.Add("1");

        // assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnsTheSum()
    {
        // Arrange
        var calculator = new StringCalculator();

        // Act
        var result = calculator.Add("1,2");

        // Assert
        Assert.Equal(3, result);
    }
}