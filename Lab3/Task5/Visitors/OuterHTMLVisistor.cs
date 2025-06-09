using Lab3.Task5.Nodes;

namespace Lab3.Task5.Visitors;

public class OuterHTMLVisitor : INodeVisitor
{
    public string Output = string.Empty;

    public void Visit(LightElementNode node)
    {
        string attributes = "";
        if (node.Attributes.Count() > 0)
        {
            var attributeList = node.Attributes.Select(attr => $"{attr.Key}=\"{attr.Value}\"");
            attributes = " " + string.Join(" ", attributeList);
        }
        string openingTag = $"<{node.TagName}{attributes}>";
        Output += openingTag;

        foreach (var child in node.Children)
        {
            child.Accept(this);
        }

        string closingTag = node.ElementClosingType == ClosingType.Double ? $"</{node.TagName}>" : "";
        Output += closingTag;
    }

    public void Visit(LightTextNode node)
    {
        Output += node.Text;
    }
}
