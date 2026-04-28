/// <summary>
/// Clase base abstracta que define el contrato para 
/// todos los empleados
/// </summary>
public abstract class Empleado
{
    private string _nombre;
    private string _apellido;

    public string Nombre
    {
        get => _nombre;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("El nombre no puede estar vacío");
            _nombre = value;
        }
    }

    public string Apellido
    {
        get => _apellido;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("El apellido no puede estar vacío");
            _apellido = value;
        }
    }

    // Propiedad de solo lectura
    public string NombreCompleto => $"{Nombre} {Apellido}";

    protected Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }
    /// <summary>
    /// Método abstracto que cada subclase debe implementar
    /// obligatoriamente
    /// </summary>
    /// <returns></returns>
    public abstract decimal CalcularIngresos();

    /// <summary>
    /// Método virtual que puede ser sobrescrito opcionalmente
    /// </summary>
    /// <returns></returns>
    public virtual string ObtenerInformacion()
    {
        return $"Empleado: {NombreCompleto}";
    }
}

