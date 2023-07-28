namespace HealthPartners.Domain.Rules;

public sealed class NumberRule : IGameRule
{
    public string Result { get; private set; } = string.Empty;

    public bool Applies(int number)
    {
        if (number % 15 == 0) return false;
        if (number % 3 == 0) return false;
        if (number % 5 == 0) return false;

        Result = number.ToString();
        return true;
    }
}