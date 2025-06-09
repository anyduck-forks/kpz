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

public class LightElementNode : LightNodeWithLifecycle
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

    protected override void OnCreated(TextWriter logger) { logger.WriteLine($"{TagName} created"); }
    protected override void OnInserted(TextWriter logger) { logger.WriteLine($"{TagName} inserted"); }

    protected override void OnClassListApplied(TextWriter logger)
    {
        var classList = string.Join(" ", Attributes.Where(attr => attr.Key == "class").Select(attr => attr.Value));
        logger.WriteLine($"Class list applied to {TagName}: {classList}");
    }

    protected override void OnStylesApplied(TextWriter logger) { logger.WriteLine($"Styles applied to {TagName}"); }
    protected override void OnTextRendered(TextWriter logger) { logger.WriteLine($"{TagName} rendered"); }
    protected override void OnRemoved(TextWriter logger) { logger.WriteLine($"{TagName} removed"); }
}
