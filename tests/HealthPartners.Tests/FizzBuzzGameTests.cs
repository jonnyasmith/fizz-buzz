using HealthPartners.Domain;

namespace HealthPartners.Tests;

public sealed class FizzBuzzGameTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, nameof(FizzBuzzResult.Fizz))]
    [InlineData(4, "4")]
    [InlineData(5, nameof(FizzBuzzResult.Buzz))]
    [InlineData(6, nameof(FizzBuzzResult.Fizz))]
    [InlineData(7, "7")]
    [InlineData(8, "8")]
    [InlineData(9, nameof(FizzBuzzResult.Fizz))]
    [InlineData(10, nameof(FizzBuzzResult.Buzz))]
    [InlineData(11, "11")]
    [InlineData(12, nameof(FizzBuzzResult.Fizz))]
    [InlineData(13, "13")]
    [InlineData(14, "14")]
    [InlineData(15, nameof(FizzBuzzResult.FizzBuzz))]
    public void Play_GivenARangeOfNumbers_ShouldOutputFizzBuzzResults(int number, string expected)
    {
        var numbers = new List<int> { number };
        var writer = new Action<string>(result => Assert.Equal(expected, result));
        var game = new FizzBuzzGame();
        
        game.Play(numbers, writer);
    }
}