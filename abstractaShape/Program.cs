class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz de diferentes formas
        Shape[] shapes = new Shape[]
        {
            new Triangle(5, 10),
            new Rectangle(4, 6),
            new Circle(7)
        };

        // Crear una matriz para almacenar las áreas
        double[] areas = new double[shapes.Length];

        // Calcular el área de cada forma
        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
        }

        // Mostrar las áreas
        for (int i = 0; i < areas.Length; i++)
        {
            Console.WriteLine($"Área de la forma {i + 1}: {areas[i]}");
        }
    }
}