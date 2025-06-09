using Lab3.Task5.Nodes;

namespace Lab3.Task5.Iterators;


public class DepthFirstNodeIterator : INodeIterator
{
    private Stack<LightNode> stack;
    private LightNode current;
    private LightNode root;

    public DepthFirstNodeIterator(LightNode root)
    {
        this.root = root;
        this.current = root;
        this.stack = new();
        Reset();
    }

    public LightNode Current() => current;

    public bool MoveNext()
    {
        if (stack.Count == 0)
            return false;

        current = stack.Pop();

        if (current is LightElementNode element)
        {
            for (int i = element.Children.Count - 1; i >= 0; i--)
            {
                LightNode child = element.Children[i];
                stack.Push(child);
            }
        }

        return true;
    }

    public void Reset()
    {
        stack.Clear();
        current = root;
        stack.Push(root);
    }

    public void Dispose()
    {
        stack.Clear();
    }
}
