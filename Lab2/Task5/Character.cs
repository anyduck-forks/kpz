namespace Lab2.Task5;

public class Character
{
    public string Name { get; set; } = "Default";
    public int Height { get; set; } = 170;
    public string Build { get; set; } = "Normal";
    public string HairColor { get; set; } = "Black";
    public string EyeColor { get; set; } = "Black";
    public string Clothing { get; set; } = "None";
    public List<string> Inventory { get; set; } = [];
    public string Alignment { get; set; } = "Neutral";

    public override string ToString()
    {
        return $"""
        Name: {Name}
        Height: {Height}
        Build: {Build}
        HairColor: {HairColor}
        EyeColor: {EyeColor}
        Clothing: {Clothing}
        Inventory: {Inventory}
        Alignment: {Alignment}
        """;
    }
}