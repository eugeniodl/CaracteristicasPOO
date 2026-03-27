public class Docente : Usuario
{
    private string? _especialidad;

    public string? Especialidad
    {
        get { return _especialidad; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _especialidad = value;
        }
    }
    public override void MostrarRol()
    {
        Console.WriteLine("Docente");
    }
}

