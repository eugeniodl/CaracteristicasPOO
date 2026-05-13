public abstract class Empleado
{
    private string? _nombre;
    private string? _apellido;

    public string? Nombre
    {
        get => _nombre;
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío");
            _nombre = value;
        }
    }

    public string? Apellido
    {
        get => _apellido;
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El apellido no puede estar vacío");
            _apellido = value;
        }
    }

    public string NombreCompleto => $"{Nombre} {Apellido}";

    protected Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    // Sobrecarga: Constructor recibe nombre completo y lo procesa para asignar nombre y apellido
    protected Empleado(string nombreCompleto) : this
        (nombreCompleto?.Split(' ')[0] ?? "Sin",
        nombreCompleto?.Contains(' ') == true ? nombreCompleto.Substring(
            nombreCompleto.IndexOf(' ') + 1) : "Nombre")
    {
        Console.WriteLine($"Constructor sobrecargado: nombre completo procesado");
    }

    /// <summary>
    /// Método abstracto que cada subclase debe implementar obligatoriamente
    /// </summary>
    public abstract decimal CalcularIngresos();
    /// <summary>
    /// Método virtual que puede ser sobrescrito opcionalmente
    /// </summary>
    /// <returns></returns>
    public virtual string MostrarInformacion()
    {
        return $"Empleado: {NombreCompleto}";
    }

    // Método sobrecargado que permite calcular ingresos con un factor de ajuste
    public virtual decimal CalcularIngresos(decimal factorAjuste)
    {
        return CalcularIngresos() * factorAjuste;
    }

    // Método sobrecargado que muestra información en diferentes formatos
    public virtual string MostrarInformacion(string formato)
    {
        return formato == "detallado" ?
            $"=== {MostrarInformacion()} ===" :
            MostrarInformacion();
    }
}