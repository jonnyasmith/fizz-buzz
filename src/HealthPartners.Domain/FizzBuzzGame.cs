namespace HealthPartners.Domain;

public sealed class FizzBuzzGame
{
    public void Play(IEnumerable<int> numbers, Action<string> writer)
    {
        foreach (var number in numbers)
        {
            if (number % 15 == 0)
            {
                writer("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                writer("Fizz");
            }
            else if (number % 5 == 0)
            {
                writer("Buzz");
            }
            else
            {
                writer(number.ToString());
            }
        }
    }
}