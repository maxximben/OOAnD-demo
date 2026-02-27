using OOAnD;
using FluentAssertions;

namespace tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        int a = 5;
        int b = 7;
        
        int result = Calculator.Add(a, b);
        
        result.Should().Be(12);
    }

    [Fact]
    public void MultiplyTwoNumbersReturnsCorrectResult()
    {
        int a = 6;
        int b = 7;

        int result = Calculator.Multiply(a, b);

        Assert.Equal(42, result);
    }
}