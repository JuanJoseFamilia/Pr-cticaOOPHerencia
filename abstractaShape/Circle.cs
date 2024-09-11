public class Circle : Shape
{
    // Constructor que toma el radio e inicializa ancho y alto con el mismo valor
    public Circle(double radius) : base(radius, radius) { }

    // Implementación del cálculo del área para el círculo
    public override double CalculateSurface()
    {
        return Math.PI * Width * Width;
    }
}