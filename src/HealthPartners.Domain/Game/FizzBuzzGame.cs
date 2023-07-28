using HealthPartners.Domain.Rules;

namespace HealthPartners.Domain.Game;

public sealed class FizzBuzzGame : IFizzBuzzGame
{
    private readonly IList<IGameRule> _rules;

    public FizzBuzzGame(IList<IGameRule> rules)
    {
        _rules = rules;
    }

    public void Play(IEnumerable<int> numbers, Action<string> writer)
    {
        foreach (var number in numbers)
        {
            var rule = _rules.First(r => r.Applies(number));
            var result = rule.Result;
            writer(result);
        }
    }
}