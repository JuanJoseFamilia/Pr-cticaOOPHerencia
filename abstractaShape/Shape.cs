public abstract class Shape
{
    // Campos de ancho y alto
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor que inicializa ancho y alto
    protected Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Método abstracto para calcular el área
    public abstract double CalculateSurface();
}