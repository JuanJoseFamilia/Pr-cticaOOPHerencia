class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de Estudiante y Profesor
        var estudiante1 = new Estudiante("Juan Pérez", 1234);
        var profesor1 = new Profesor("María López");

        // Crear curso y agregar al profesor
        var curso1 = new Curso("Matemáticas", 30, 15);
        profesor1.AgregarCurso(curso1);

        // Crear una clase y agregar estudiante y profesor
        var clase1 = new Clase("Clase A");
        clase1.AgregarEstudiante(estudiante1);
        clase1.AgregarProfesor(profesor1);

        // Mostrar información
        estudiante1.ObtenerInfo();
        profesor1.ObtenerInfo();
    }
}
