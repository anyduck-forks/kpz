namespace Lab3.Task6.Nodes;

public class LightTextNode(string text) : LightNode
{
    public string Text { get; set; } = text;
    public override string OuterHTML => Text;
    public override string InnerHTML => Text;
}