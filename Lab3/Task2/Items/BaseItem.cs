using Lab3.Task2.Heroes;

namespace Lab3.Task2.Items;


public abstract class BaseItem(IHero hero, string name, int strength, int intelligence, int defense) : IHero
{
    public string Name => Hero.Name;
    public int Strength => Hero.Strength + strength;
    public int Intelligence => Hero.Intelligence + intelligence;
    public int Defense => Hero.Defense + defense;
    public IList<string> Items => Hero.Items.Concat([name]).ToList();
    protected IHero Hero = hero;
}