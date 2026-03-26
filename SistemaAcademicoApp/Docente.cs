public class Docente : Persona
{
    private string? _asignatura;

    public Docente(string? nombre, string? identificacion,
        string? asignatura) 
        : base(nombre, identificacion)
    {
        Asignatura = asignatura;
    }

    public string? Asignatura { 
        get => _asignatura; 
        set => _asignatura = value; }

    public override void MostrarRol()
    {
        Console.WriteLine("Docente");
    }
}

