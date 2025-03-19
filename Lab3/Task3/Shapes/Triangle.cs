using Lab3.Task3.Renderers;

namespace Lab3.Task3.Shapes;


public class Triangle : Shape
{
    private double _side1;
    private double _side2;
    private double _side3;


    public Triangle(IRenderer renderer, double side1, double side2, double side3) : base(renderer)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public override void Draw()
    {
        Renderer.RenderTriangle(_side1, _side2, _side3);
    }
}