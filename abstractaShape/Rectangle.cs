public class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height) { }

    // Implementación del cálculo del área para el rectángulo
    public override double CalculateSurface()
    {
        return Width * Height;
    }
}
