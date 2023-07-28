using HealthPartners.Domain.Game;

namespace HealthPartners.Tests;

public sealed class GameBuilderTests
{
    [Fact]
    public void GameBuilder_ShouldConstructAndReturnGame()
    {
        var game = GameBuilder.Build();

        Assert.NotNull(game);
    }
}