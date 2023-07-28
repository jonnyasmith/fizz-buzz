using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Game;

namespace HealthPartners.Domain.Rules;

public sealed class NumberRule : IGameRule
{
    private readonly ICalculator _calculator;

    public NumberRule(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public bool Applies(int number)
    {
        var numberResult = _calculator.Calculate(number) == FizzBuzzResult.Number;

        if (numberResult) Result = number.ToString();

        return numberResult;
    }

    public string Result { get; private set; } = string.Empty;
}