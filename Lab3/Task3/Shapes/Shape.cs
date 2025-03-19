using Lab3.Task3.Renderers;

namespace Lab3.Task3.Shapes;


public abstract class Shape
{
    protected IRenderer Renderer;

    protected Shape(IRenderer renderer)
    {
        Renderer = renderer;
    }

    public abstract void Draw();
}