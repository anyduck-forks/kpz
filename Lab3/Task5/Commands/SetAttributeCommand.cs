using Lab3.Task5.Nodes;

namespace Lab3.Task5.Commands;


public class SetAttributeCommand(LightElementNode node, string key, string value) : ICommand
{
    private readonly LightElementNode node = node;
    private readonly string key = key;
    private readonly string value = value;
    private string? oldValue = null;

    public void Execute()
    {
        node.Attributes.TryGetValue(key, out oldValue);
        node.Attributes[key] = value;
    }

    public void Undo()
    {
        if (oldValue != null)
        {
            node.Attributes[key] = oldValue;
        }
        else
        {
            node.Attributes.Remove(key);
        }
    }
}
