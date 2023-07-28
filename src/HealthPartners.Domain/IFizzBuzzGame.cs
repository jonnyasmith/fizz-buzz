namespace HealthPartners.Domain;

public interface IFizzBuzzGame
{
    void Play(IEnumerable<int> numbers, Action<string> writer);
}