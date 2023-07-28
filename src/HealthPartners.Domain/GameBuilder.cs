using System.Reflection;

namespace HealthPartners.Domain;

public static class GameBuilder
{
    public static IFizzBuzzGame Build()
    {
        var types = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.Namespace!.StartsWith("HealthPartners."))
            .ToList();
        
        var gameType = types.First(type =>
            typeof(IFizzBuzzGame).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false });

        var game = Activator.CreateInstance(gameType) as IFizzBuzzGame;

        return game!;
    }
}