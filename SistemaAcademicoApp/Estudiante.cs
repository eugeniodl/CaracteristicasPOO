public class Estudiante : Persona
{
    private string? _carrera;

    public Estudiante(string? nombre, string? identificacion,
        string? carrera) 
        : base(nombre, identificacion)
    {
        Carrera = carrera;
    }

    public string? Carrera { 
        get => _carrera; 
        set => _carrera = value; }

    public override void MostrarRol()
    {
        Console.WriteLine("Estudiante");
    }
}

