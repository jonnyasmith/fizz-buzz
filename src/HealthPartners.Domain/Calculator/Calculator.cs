using HealthPartners.Domain.Game;

namespace HealthPartners.Domain.Calculator;

public class Calculator : ICalculator
{
    public FizzBuzzResult Calculate(int number)
    {
        if (number % 15 == 0) return FizzBuzzResult.FizzBuzz;
        if (number % 3 == 0) return FizzBuzzResult.Fizz;
        if (number % 5 == 0) return FizzBuzzResult.Buzz;

        return FizzBuzzResult.Number;
    }
}