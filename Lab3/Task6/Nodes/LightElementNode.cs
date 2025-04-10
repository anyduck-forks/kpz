namespace Lab3.Task6.Nodes;

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
    public string FontFamily { get; set; } = "Arial";
    public int FontSize { get; set; } = 16;
    public int FontWeight { get; set; } = 400;
    public int PaddingLeft { get; set; } = 0;
    public int PaddingRight { get; set; } = 0;
    public int PaddingTop { get; set; } = 0;
    public int PaddingBottom { get; set; } = 0;
    public int MarginLeft { get; set; } = 0;
    public int MarginRight { get; set; } = 0;
    public int MarginTop { get; set; } = 0;
    public int MarginBottom { get; set; } = 0;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<LightNode> Children { get; set; } = new List<LightNode>();

    public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
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