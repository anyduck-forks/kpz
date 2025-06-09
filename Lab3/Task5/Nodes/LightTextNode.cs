using Lab3.Task5.Visitors;

namespace Lab3.Task5.Nodes;

public class LightTextNode(string text) : LightNodeWithLifecycle
{
    public string Text { get; set; } = text;
    public override void Accept(INodeVisitor visitor) => visitor.Visit(this);

    protected override void OnCreated(TextWriter logger) { logger.WriteLine($"TextNode created: {Text}"); }
    protected override void OnInserted(TextWriter logger) { logger.WriteLine($"TextNode inserted: {Text}"); }
    protected override void OnStylesApplied(TextWriter logger) { logger.WriteLine($"Styles applied to TextNode: {Text}"); }
    protected override void OnTextRendered(TextWriter logger) { logger.WriteLine($"TextNode rendered: {Text}"); }
    protected override void OnRemoved(TextWriter logger) { logger.WriteLine($"TextNode removed: {Text}"); }
}
