namespace Lab3.Task3.Renderers;


public interface IRenderer
{
    void RenderCircle(double radius);
    void RenderSquare(double side);
    void RenderTriangle(double side1, double side2, double side3);
}