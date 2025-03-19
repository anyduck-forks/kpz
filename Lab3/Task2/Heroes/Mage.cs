namespace Lab3.Task2.Heroes;


public class Mage(string name) : IHero
{
    public string Name { get; } = name;
    public int Strength { get; } = 5;
    public int Intelligence { get; } = 12;
    public int Defense { get; } = 2;
    public IList<string> Items { get; } = ["Hat"];
}