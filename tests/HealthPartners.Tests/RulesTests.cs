using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Game;
using HealthPartners.Domain.Rules;

namespace HealthPartners.Tests;

public sealed class RulesTests
{
    private readonly Calculator _calculator;

    public RulesTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(4, false)]
    [InlineData(5, false)]
    [InlineData(6, false)]
    [InlineData(7, false)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(11, false)]
    [InlineData(12, false)]
    [InlineData(13, false)]
    [InlineData(14, false)]
    [InlineData(15, true)]
    [InlineData(30, true)]
    [InlineData(45, true)]
    [InlineData(60, true)]
    [InlineData(75, true)]
    [InlineData(90, true)]
    public void FizzBuzzRule_ShouldCheckNumbersAreDivisibleBy3And5_AndResultShouldBeFizzBuzz(int number, bool expected)
    {
        var rule = new FizzBuzzRule(_calculator);
        var result = rule.Applies(number);

        Assert.Equal(expected, result);
        Assert.Equal(nameof(FizzBuzzResult.FizzBuzz), rule.Result);
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, false)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, false)]
    [InlineData(6, true)]
    [InlineData(7, false)]
    [InlineData(8, false)]
    [InlineData(9, true)]
    [InlineData(10, false)]
    [InlineData(11, false)]
    [InlineData(12, true)]
    [InlineData(13, false)]
    [InlineData(14, false)]
    [InlineData(15, false)]
    public void FizzRule_ShouldCheckNumbersAreDivisibleBy3AndNot5_AndResultShouldBeFizz(int number, bool expected)
    {
        var rule = new FizzRule(_calculator);
        var result = rule.Applies(number);

        Assert.Equal(expected, result);
        Assert.Equal(nameof(FizzBuzzResult.Fizz), rule.Result);
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, false)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, true)]
    [InlineData(11, false)]
    [InlineData(12, false)]
    [InlineData(13, false)]
    [InlineData(14, false)]
    [InlineData(15, false)]
    public void BuzzRule_ShouldCheckNumbersAreDivisibleBy5AndNot3_AndResultShouldBeBuzz(int number, bool expected)
    {
        var rule = new BuzzRule(_calculator);
        var result = rule.Applies(number);

        Assert.Equal(expected, result);
        Assert.Equal(nameof(FizzBuzzResult.Buzz), rule.Result);
    }

    [Theory]
    [InlineData(1, true, "1")]
    [InlineData(2, true, "2")]
    [InlineData(3, false, null)]
    [InlineData(4, true, "4")]
    [InlineData(5, false, null)]
    [InlineData(6, false, null)]
    [InlineData(7, true, "7")]
    [InlineData(8, true, "8")]
    [InlineData(9, false, null)]
    [InlineData(10, false, null)]
    [InlineData(11, true, "11")]
    [InlineData(12, false, null)]
    [InlineData(13, true, "13")]
    [InlineData(14, true, "14")]
    [InlineData(15, false, null)]
    public void NumberRule_ShouldCheckNumbersAreNotDivisibleBy3Or5_AndResultShouldBeTheNumber(
        int number,
        bool expectedApplies,
        string expectedResult)
    {
        var rule = new NumberRule(_calculator);
        var result = rule.Applies(number);

        Assert.Equal(expectedApplies, result);
        Assert.Equal(expectedResult ?? string.Empty, rule.Result);
    }
}