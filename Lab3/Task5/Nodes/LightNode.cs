using System.Collections;
using Lab3.Task5.Iterators;

namespace Lab3.Task5.Nodes;

public abstract class LightNode: INodeIteratorAggregate
{
    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }

    public IEnumerator<LightNode> GetEnumerator()
    {
        return new DepthFirstNodeIterator(this);
    }
}
