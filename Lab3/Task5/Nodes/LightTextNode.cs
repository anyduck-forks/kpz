using Lab3.Task5.Visitors;

namespace Lab3.Task5.Nodes;

public class LightTextNode(string text) : LightNode
{
    public string Text { get; set; } = text;
    public override void Accept(INodeVisitor visitor) => visitor.Visit(this);
}
