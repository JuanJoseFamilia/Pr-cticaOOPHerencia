public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();

    public Profesor(string nombre) : base(nombre) { }

    public void AgregarCurso(Curso curso)
    {
        Cursos.Add(curso);
    }

    public override void ObtenerInfo()
    {
        Console.WriteLine($"Profesor: {Nombre}, Cursos: {string.Join(", ", Cursos.Select(c => c.Nombre))}");
    }
}
