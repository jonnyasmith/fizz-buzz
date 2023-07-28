using HealthPartners.Domain.Game;

namespace HealthPartners.Domain.Calculator;

public interface ICalculator
{
    FizzBuzzResult Calculate(int number);
}