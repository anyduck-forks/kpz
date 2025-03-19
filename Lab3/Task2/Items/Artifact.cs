using Lab3.Task2.Heroes;

namespace Lab3.Task2.Items;


public class Artifact : BaseItem
{
    public Artifact(IHero hero, string name, int intelligence) : base(hero, name, 0, intelligence, 0)
    {
    }
}