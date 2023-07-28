using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Game;

namespace HealthPartners.Tests;

public sealed class CalculatorTests
{
    [Theory]
    [InlineData(1, FizzBuzzResult.Number)]
    [InlineData(2, FizzBuzzResult.Number)]
    [InlineData(3, FizzBuzzResult.Fizz)]
    [InlineData(4, FizzBuzzResult.Number)]
    [InlineData(5, FizzBuzzResult.Buzz)]
    [InlineData(6, FizzBuzzResult.Fizz)]
    [InlineData(7, FizzBuzzResult.Number)]
    [InlineData(8, FizzBuzzResult.Number)]
    [InlineData(9, FizzBuzzResult.Fizz)]
    [InlineData(10, FizzBuzzResult.Buzz)]
    [InlineData(11, FizzBuzzResult.Number)]
    [InlineData(12, FizzBuzzResult.Fizz)]
    [InlineData(13, FizzBuzzResult.Number)]
    [InlineData(14, FizzBuzzResult.Number)]
    [InlineData(15, FizzBuzzResult.FizzBuzz)]
    public void Calculator_ShouldOutputFizzBuzzResults(int number, FizzBuzzResult expected)
    {
        var calculator = new Calculator();
        var result = calculator.Calculate(number);

        Assert.Equal(expected, result);
    }
}