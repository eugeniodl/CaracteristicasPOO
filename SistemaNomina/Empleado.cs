public abstract class Empleado
{
    private string _nombre;
    private string _apellido;

    protected string Nombre
    {
        get => _nombre;
        private set
        {
            if (string
                .IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("El nombre no puede estar vacío");
            _nombre = value;
        }
    }

    protected string Apellido
    {
        get => _apellido;
        private set
        {
            if (string
                .IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("El apellido no puede estar vacío");
            _apellido = value;
        }
    }

    protected string NombreCompleto => $"{Nombre} {Apellido}";

    protected Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }
    /// <summary>
    /// Método abstracto que cada subclase debe implementar 
    /// obligatoriamente
    /// </summary>
    public abstract decimal CalcularIngresos();

    /// <summary>
    /// Método virtual que puede ser sobrescrito opcionalmente
    /// </summary>
    public virtual string ObtenerInformacion()
    {
        return $"Empleado: {NombreCompleto}";
    }
}