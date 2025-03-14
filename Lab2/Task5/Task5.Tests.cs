using Lab2.Task5;
using Lab2.Task5.Builders;
using Xunit;

namespace Lab2.Task5.Tests;


public class BuilderTests
{
    [Fact]
    public void HeroBuilder()
    {
        var director = new CharacterDirector();
        var builder = new HeroBuilder();
        Character hero = director.ConstructL(builder);

        Assert.Equal("Detective L", hero.Name);
        Assert.Equal(179, hero.Height);
        Assert.Equal("Weak", hero.Build);
        Assert.Equal("Brown", hero.HairColor);
        Assert.Equal("Brown", hero.EyeColor);
        Assert.Equal("Rugs", hero.Clothing);
        Assert.Equal(["Sugar Cubes"], hero.Inventory);
    }

    [Fact]
    public void EnemyBuilder()
    {
        var director = new CharacterDirector();
        var builder = new EnemyBuilder();
        Character enemy = director.ConstructYagami(builder);

        Assert.Equal("Light Yagami", enemy.Name);
        Assert.Equal(180, enemy.Height);
        Assert.Equal("Weak", enemy.Build);
        Assert.Equal("Black", enemy.HairColor);
        Assert.Equal("Black", enemy.EyeColor);
        Assert.Equal("Suit", enemy.Clothing);
        Assert.Equal(["Death Note"], enemy.Inventory);
    }

}
