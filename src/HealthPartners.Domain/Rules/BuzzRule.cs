namespace HealthPartners.Domain.Rules;

public sealed class BuzzRule : IGameRule
{
    public bool Applies(int number)
    {
        return number % 5 == 0 && number % 3 != 0;
    }

    public string Result => nameof(FizzBuzzResult.Buzz);
}