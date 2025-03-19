namespace Lab3.Task2.Heroes;


public class Warrior(string name) : IHero
{
    public string Name { get; } = name;
    public int Strength { get; } = 12;
    public int Intelligence { get; } = 1;
    public int Defense { get; } = 5;
    public IList<string> Items { get; } = ["Eyepatch"];
}