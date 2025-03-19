namespace Lab3.Task3.Renderers;

public class VectorRenderer(TextWriter? writer = null) : IRenderer
{
    TextWriter Writer = writer ?? Console.Out;

    public void RenderCircle(double radius)
    {
        Writer.WriteLine($"Drawing Circle as vector graphics with radius {radius}");
    }

    public void RenderSquare(double side)
    {
        Writer.WriteLine($"Drawing Square as vector graphics with side {side}");
    }

    public void RenderTriangle(double side1, double side2, double side3) {
        Writer.WriteLine($"Drawing Triangle as vector graphics with sides {side1}, {side2}, and {side3}");
    }
}