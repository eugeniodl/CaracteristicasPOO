public abstract class Usuario
{
    private string? _nombre;
    private string? _dni;

    public string? Nombre
    {
        get { return _nombre; }
        set {
            if(!string.IsNullOrWhiteSpace(value))
                _nombre = value; 
        }
    }

    public string? DNI
    {
        get { return _dni; }
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
                _dni = value;
        }
    }
    public abstract void MostrarRol();
}

