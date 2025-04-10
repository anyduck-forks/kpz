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

    public override string OuterHTML
    {
        get
        {
            string attributes = "";
            if (Attributes.Count() > 0)
            {
                var attributeList = Attributes.Select(attr => $"{attr.Key}=\"{attr.Value}\"");
                attributes = " " + string.Join(" ", attributeList);
            }
            string openingTag = $"<{TagName}{attributes}>";
            string closingTag = ElementClosingType == ClosingType.Double ? $"</{TagName}>" : "";
            return openingTag + InnerHTML + closingTag;
        }
    }

    public override string InnerHTML
    {
        get => string.Join("", Children.Select(child => child.OuterHTML));
    }

    public int ChildCount => Children.Count;
}