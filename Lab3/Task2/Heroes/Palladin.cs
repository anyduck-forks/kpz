namespace Lab3.Task2.Heroes;


public class Palladin(string name) : IHero
{
    public string Name { get; } = name;
    public int Strength { get; } = 7;
    public int Intelligence { get; } = 7;
    public int Defense { get; } = 7;
    public IList<string> Items { get; } = [];
}