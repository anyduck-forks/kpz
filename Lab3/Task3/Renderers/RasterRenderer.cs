namespace Lab3.Task3.Renderers;


public class RasterRenderer(TextWriter? writer = null) : IRenderer
{
    TextWriter Writer = writer ?? Console.Out;

    public void RenderCircle(double radius)
    {
        Writer.WriteLine($"Drawing Circle as pixels with radius {radius}");
    }

    public void RenderSquare(double side)
    {
        Writer.WriteLine($"Drawing Square as pixels with side {side}");
    }

    public void RenderTriangle(double side1, double side2, double side3) {
        Writer.WriteLine($"Drawing Triangle as pixels with sides {side1}, {side2}, and {side3}");
    }
}