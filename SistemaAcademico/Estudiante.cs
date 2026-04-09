/// <summary>
/// Representa a un estudiante, extendiendo el tipo Persona base con propiedades y comportamiento específicos para estudiantes.
/// </summary>
public class Estudiante : Persona
{
    private string? _carnet;

    public string? Carnet
    {
        get { return _carnet; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _carnet = value;
        }
    }

    public override void MostrarRol()
    {
        Console.WriteLine("Soy estudiante");
    }
}