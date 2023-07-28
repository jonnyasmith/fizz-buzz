namespace HealthPartners.Domain.Rules;

public interface IGameRule
{
    string Result { get; }

    bool Applies(int number);
}