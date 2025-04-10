namespace Lab3.Task6.Nodes;


public class LightElementNode : LightNode
{

    public ElementType ElementType { get; set; }
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<LightNode> Children { get; set; } = new List<LightNode>();

    public LightElementNode(ElementType elementType)
    {
        ElementType = elementType;
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
            string openingTag = $"<{ElementType.TagName}{attributes}>";
            string closingTag = ElementType.ClosingType == ClosingType.Double ? $"</{ElementType.TagName}>" : "";
            return openingTag + InnerHTML + closingTag;
        }
    }

    public override string InnerHTML
    {
        get => string.Join("", Children.Select(child => child.OuterHTML));
    }

    public int ChildCount => Children.Count;
    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }
}