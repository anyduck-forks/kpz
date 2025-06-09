using Lab3.Task5.Nodes;

namespace Lab3.Task5.Commands;

public class AddChildCommand(LightElementNode parent, LightNode child) : ICommand
{
    private readonly LightElementNode parent = parent;
    private readonly LightNode child = child;

    public void Execute()
    {
        parent.AddChild(child);
    }

    public void Undo()
    {
        parent.Children.Remove(child);
    }
}
