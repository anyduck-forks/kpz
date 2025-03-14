namespace Lab2.Task4;

public class Virus(double weight, int age, string name, string kind) : IPrototype<Virus>
{
    public double Weight { get; set; } = weight;
    public int Age { get; set; } = age;
    public string Name { get; set; } = name;
    public string Kind { get; set; } = kind;
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus Clone()
    {
        var virus = new Virus(Weight, Age, Name, Kind);
        virus.Children = new List<Virus>();
        foreach (var child in Children)
        {
            virus.Children.Add(child.Clone());
        }
        return virus;
    }
}