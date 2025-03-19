using Lab3.Task3.Renderers;
using Lab3.Task3.Shapes;
using Xunit;

namespace Lab3.Task3.Tests;

public class BridgesTests
{
    [Fact]
    public void RenderVectorCircle()
    {
        var writer = new StringWriter();
        IRenderer renderer = new VectorRenderer(writer);
        Shape circle = new Circle(renderer, 5);

        circle.Draw();
        Assert.Equal("Drawing Circle as vector graphics with radius 5", writer.ToString().Trim());
    }

    [Fact]
    public void RenderRasterSquare()
    {
        var writer = new StringWriter();
        IRenderer renderer = new RasterRenderer(writer);
        Shape square = new Square(renderer, 10);

        square.Draw();
        Assert.Equal("Drawing Square as pixels with side 10", writer.ToString().Trim());
    }

    [Fact]
    public void RenderVectorTriangle()
    {
        var writer = new StringWriter();
        IRenderer renderer = new VectorRenderer(writer);
        Shape triangle = new Triangle(renderer, 3, 4, 5);

        triangle.Draw();
        Assert.Equal("Drawing Triangle as vector graphics with sides 3, 4, and 5", writer.ToString().Trim());
    }

    [Fact]
    public void RenderRasterTriangle()
    {
        var writer = new StringWriter();
        IRenderer renderer = new RasterRenderer(writer);
        Shape triangle = new Triangle(renderer, 6, 8, 9);

        triangle.Draw();
        Assert.Equal("Drawing Triangle as pixels with sides 6, 8, and 9", writer.ToString().Trim());
    }
}