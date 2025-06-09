namespace Lab3.Task5.Nodes;

public abstract class LightNodeWithLifecycle : LightNode
{
    public void Render(TextWriter logger)
    {
        OnCreated(logger);
        OnInserted(logger);
        OnClassListApplied(logger);
        OnStylesApplied(logger);
        OnTextRendered(logger);
        OnRemoved(logger);
    }

    protected virtual void OnCreated(TextWriter logger) { }
    protected virtual void OnInserted(TextWriter logger) { }
    protected virtual void OnClassListApplied(TextWriter logger) { }
    protected virtual void OnStylesApplied(TextWriter logger) { }
    protected virtual void OnTextRendered(TextWriter logger) { }
    protected virtual void OnRemoved(TextWriter logger) { }
}
