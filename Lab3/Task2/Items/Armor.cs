using Lab3.Task2.Heroes;

namespace Lab3.Task2.Items;


public class Armor : BaseItem
{
    public Armor(IHero hero, string name, int defense) : base(hero, name, 0, 0, defense)
    {
    }
}