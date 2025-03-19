using Lab3.Task2.Heroes;
using Lab3.Task2.Items;
using Xunit;

namespace Lab3.Task2.Tests;

public class DecoratorsTests
{
    [Fact]
    public void HeroDecorationTest()
    {
        IHero mage =  new Weapon(new Mage("Yennefer"), "Wand", -3, -1, 9);

        Assert.Equal("Yennefer", mage.Name);
        Assert.Equal(2, mage.Strength);
        Assert.Equal(1, mage.Defense);
        Assert.Equal(21, mage.Intelligence);
        Assert.Equal(["Hat", "Wand"], mage.Items);
    }

    [Fact]
    public void MultipleDecoratorsTest()
    {
        IHero warrior = new Warrior("Vesemir");
        warrior = new Armor(warrior, "Leather Armor", 2);
        warrior = new Weapon(warrior, "Silber Sword", 7, 0, 0);
        warrior = new Artifact(warrior, "Silver Medallion", 3);

        Assert.Equal("Vesemir", warrior.Name);
        Assert.Equal(19, warrior.Strength);
        Assert.Equal(7, warrior.Defense);
        Assert.Equal(4, warrior.Intelligence);
        Assert.Equal(["Eyepatch", "Leather Armor", "Silber Sword", "Silver Medallion"], warrior.Items);
        Assert.Equal(65, SlashMahicImbuedSword(warrior));
    }

    public int SlashMahicImbuedSword(IHero hero) {
        return 3 * hero.Strength + 2 * hero.Intelligence;
    }
}
