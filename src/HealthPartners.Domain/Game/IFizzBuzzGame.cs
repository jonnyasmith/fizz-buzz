namespace HealthPartners.Domain.Game;

public interface IFizzBuzzGame
{
    void Play(IEnumerable<int> numbers, Action<string> writer);
}