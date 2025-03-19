using Lab3.Task3.Renderers;

namespace Lab3.Task3.Shapes;


public class Square : Shape
{
    private double _side;

    public Square(IRenderer renderer, double side) : base(renderer)
    {
        _side = side;
    }

    public override void Draw()
    {
        Renderer.RenderSquare(_side);
    }
}