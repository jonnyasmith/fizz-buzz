namespace HealthPartners.Domain;

public sealed class FizzBuzzGame
{
    public void Play(IEnumerable<int> numbers, Action<string> writer)
    {
        foreach (var number in numbers)
        {
            if (number % 15 == 0)
            {
                writer(nameof(FizzBuzzResult.FizzBuzz));
            }
            else if (number % 3 == 0)
            {
                writer(nameof(FizzBuzzResult.Fizz));
            }
            else if (number % 5 == 0)
            {
                writer(nameof(FizzBuzzResult.Buzz));
            }
            else
            {
                writer(number.ToString());
            }
        }
    }
}