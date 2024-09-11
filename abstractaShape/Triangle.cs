public class Triangle : Shape
{
    public Triangle(double baseLength, double height) : base(baseLength, height) { }

    // Implementación del cálculo del área para el triángulo
    public override double CalculateSurface()
    {
        return (Width * Height) / 2;
    }
}