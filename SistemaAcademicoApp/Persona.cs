public abstract class Persona
{
    private string? _nombre;
    private string? _identificacion;

    public Persona(string? nombre, string? identificacion)
    {
        Nombre = nombre;
        Identificacion = identificacion;
    }

    public string? Nombre
    {
        get
        {
            return _nombre;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _nombre = value;
            }            
        }
    }

    public string? Identificacion
    {
        get
        {
            return _identificacion;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _identificacion = value;
            }
        }
    }

    // Método abstracto para mostrar rol de la persona
    public abstract void MostrarRol();
}

