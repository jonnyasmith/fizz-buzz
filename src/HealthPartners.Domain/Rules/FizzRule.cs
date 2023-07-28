using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Game;

namespace HealthPartners.Domain.Rules;

public sealed class FizzRule : IGameRule
{
    private readonly ICalculator _calculator;

    public FizzRule(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public bool Applies(int number)
    {
        return _calculator.Calculate(number) == FizzBuzzResult.Fizz;
    }

    public string Result => nameof(FizzBuzzResult.Fizz);
}