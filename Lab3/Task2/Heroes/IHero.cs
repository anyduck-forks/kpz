namespace Lab3.Task2.Heroes;

public interface IHero
{
    string Name { get; }
    int Strength { get; }
    int Intelligence { get; }
    int Defense { get; }
    IList<string> Items { get; }
    public virtual string GetDescription()
    {
        return $"""
            {Name} ({Strength} STR, {Intelligence} INT, {Defense} DEF)
            Equipped Items: [{string.Join(", ", Items)}]
        """;
    }
}