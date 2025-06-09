using System.Collections;
using Lab3.Task5.Nodes;

namespace Lab3.Task5.Iterators;

public interface INodeIterator : IEnumerator<LightNode>
{
    object IEnumerator.Current => Current();
    LightNode IEnumerator<LightNode>.Current => Current();
    public new LightNode Current();
    public new bool MoveNext();
    public new void Reset();
    public new void Dispose();
}
