/// <summary>
/// Representa a un profesor con un área de especialización específica.
/// </summary>
public class Docente : Persona
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
        Console.WriteLine("Soy docente");
    }
}