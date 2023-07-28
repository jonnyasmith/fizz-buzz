using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Game;

namespace HealthPartners.Domain.Rules;

public sealed class FizzBuzzRule : IGameRule
{
    private readonly ICalculator _calculator;

    public FizzBuzzRule(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public bool Applies(int number)
    {
        return _calculator.Calculate(number) == FizzBuzzResult.FizzBuzz;
    }

    public string Result => nameof(FizzBuzzResult.FizzBuzz);
}