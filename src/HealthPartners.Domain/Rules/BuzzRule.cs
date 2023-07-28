using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Game;

namespace HealthPartners.Domain.Rules;

public sealed class BuzzRule : IGameRule
{
    private readonly ICalculator _calculator;

    public BuzzRule(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public bool Applies(int number)
    {
        return _calculator.Calculate(number) == FizzBuzzResult.Buzz;
    }

    public string Result => nameof(FizzBuzzResult.Buzz);
}