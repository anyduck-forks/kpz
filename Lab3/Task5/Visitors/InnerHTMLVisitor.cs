using Lab3.Task5.Nodes;

namespace Lab3.Task5.Visitors;

public class InnerHTMLVisitor : INodeVisitor
{
    public string Output = string.Empty;

    public void Visit(LightElementNode node)
    {
        foreach (var child in node.Children)
        {
            var visitor = new OuterHTMLVisitor();
            child.Accept(visitor);
            Output += visitor.Output;
        }
    }

    public void Visit(LightTextNode node)
    {
        Output += node.Text;
    }
}
