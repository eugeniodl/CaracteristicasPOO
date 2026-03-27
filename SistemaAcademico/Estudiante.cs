public class Estudiante : Usuario
{
    private string? _carnet;

    public string? Carnet
    {
        get { return _carnet; }
        set {
            if(!string.IsNullOrWhiteSpace(value))
                _carnet = value; 
        }
    }

    public override void MostrarRol()
    {
        Console.WriteLine("Estudiante");
    }
}

