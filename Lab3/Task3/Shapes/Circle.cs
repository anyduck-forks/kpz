using Lab3.Task3.Renderers;

namespace Lab3.Task3.Shapes;


public class Circle : Shape
{
    private double _radius;

    public Circle(IRenderer renderer, double radius) : base(renderer)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        Renderer.RenderCircle(_radius);
    }
}