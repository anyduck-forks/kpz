using Lab3.Task5.Visitors;

namespace Lab3.Task5.Nodes;

public enum DisplayType
{
    Block,
    Inline,
    InlineBlock,
    Flex,
    Grid,
    None
}
public enum ClosingType
{
    Single,
    Double
}

public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public DisplayType ElementDisplayType { get; set; } = DisplayType.Block;
    public ClosingType ElementClosingType { get; set; } = ClosingType.Double;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<LightNode> Children { get; set; } = new List<LightNode>();

    public LightElementNode(string tagName, DisplayType displayType = DisplayType.Block, ClosingType closingType = ClosingType.Double)
    {
        TagName = tagName;
        ElementDisplayType = displayType;
        ElementClosingType = closingType;
    }

    public override void Accept(INodeVisitor visitor) => visitor.Visit(this);
    public int ChildCount => Children.Count;

    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }
}
