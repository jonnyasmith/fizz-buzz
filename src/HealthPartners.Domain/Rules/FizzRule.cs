namespace HealthPartners.Domain.Rules;

public sealed class FizzRule : IGameRule
{
    public bool Applies(int number)
    {
        return number % 3 == 0 && number % 5 != 0;
    }

    public string Result => nameof(FizzBuzzResult.Fizz);
}