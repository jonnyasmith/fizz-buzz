using System.Reflection;
using HealthPartners.Domain.Rules;

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

        var rulesTypes = types.Where(type =>
            typeof(IGameRule).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false }).ToList();

        var rules = rulesTypes.Select(type => Activator.CreateInstance(type) as IGameRule).ToList();

        var gameType = types.First(type =>
            typeof(IFizzBuzzGame).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false });

        var game = Activator.CreateInstance(gameType, rules) as IFizzBuzzGame;

        return game!;
    }
}