using System.Collections;
using Lab3.Task5.Nodes;

namespace Lab3.Task5.Iterators;

public interface INodeIteratorAggregate : IEnumerable<LightNode>
{
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
