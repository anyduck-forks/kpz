using Lab3.Task5.Nodes;

namespace Lab3.Task5.Visitors;

public interface INodeVisitor
{
    void Visit(LightElementNode node);
    void Visit(LightTextNode node);
}
