using System.Reflection;
using HealthPartners.Domain.Calculator;
using HealthPartners.Domain.Rules;

namespace HealthPartners.Domain.Game;

public static class GameBuilder
{
    public static IFizzBuzzGame Build()
    {
        var types = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.Namespace!.StartsWith("HealthPartners."))
            .ToList();

        var calculatorType = types.First(type =>
            typeof(ICalculator).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false });

        var calculator = Activator.CreateInstance(calculatorType) as ICalculator;

        var rulesTypes = types.Where(type =>
            typeof(IGameRule).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false }).ToList();

        var rules = rulesTypes.Select(type => Activator.CreateInstance(type, calculator) as IGameRule).ToList();

        var gameType = types.First(type =>
            typeof(IFizzBuzzGame).IsAssignableFrom(type) && type is { IsInterface: false, IsAbstract: false });

        var game = Activator.CreateInstance(gameType, rules) as IFizzBuzzGame;

        return game!;
    }
}