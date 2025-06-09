using Lab3.Task5.Iterators;
using Lab3.Task5.Visitors;

namespace Lab3.Task5.Nodes;

public abstract class LightNode : INodeIteratorAggregate
{
    public abstract void Accept(INodeVisitor visitor);

    public IEnumerator<LightNode> GetEnumerator()
    {
        return new DepthFirstNodeIterator(this);
    }

    public string OuterHTML
    {
        get
        {
            var visitor = new OuterHTMLVisitor();
            Accept(visitor);
            return visitor.Output;
        }
    }
    public string InnerHTML
    {
        get
        {
            var visitor = new InnerHTMLVisitor();
            Accept(visitor);
            return visitor.Output;
        }
    }
}
