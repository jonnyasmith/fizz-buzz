namespace HealthPartners.Domain.Rules;

public sealed class FizzBuzzRule : IGameRule
{
    public bool Applies(int number)
    {
        return number % 15 == 0;
    }


    public string Result => nameof(FizzBuzzResult.FizzBuzz);
}