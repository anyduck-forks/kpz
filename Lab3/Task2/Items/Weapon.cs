using Lab3.Task2.Heroes;

namespace Lab3.Task2.Items;


public class Weapon : BaseItem
{
    public Weapon(IHero hero, string name, int strength, int defense, int intelligence) : base(hero, name, strength, intelligence, defense)
    {
    }
}