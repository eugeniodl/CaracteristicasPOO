/// <summary>
/// Clase que representa la inscripción de un estudiante a un curso.
/// </summary>
public class InscripcionCurso
{
    // Atributos privados
    private string estudiante;
    private double costo;
    private int duracionMeses;
    private DateTime fecha;

    // Constante de descuento (10%)
    private const double DESCUENTO = 0.10;

    // Propiedades públicas con validación
    public string Estudiante
    {
        get { return estudiante; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre del estudiante no puede estar vacío.");
            estudiante = value;
        }
    }

    public double Costo
    {
        get { return costo; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El costo debe ser mayor que cero.");
            costo = value;
        }
    }

    public int DuracionMeses
    {
        get { return duracionMeses; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("La duración debe ser mayor que cero.");
            duracionMeses = value;
        }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("La fecha no puede ser futura.");
            fecha = value;
        }
    }

    /// <summary>
    /// Constructor principal
    /// </summary>
    public InscripcionCurso(string estudiante, double costo, int duracionMeses)
    {
        Estudiante = estudiante;
        Costo = costo;
        DuracionMeses = duracionMeses;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Constructor sobrecargado (duración por defecto: 1 mes)
    /// </summary>
    public InscripcionCurso(string estudiante, double costo)
    {
        Estudiante = estudiante;
        Costo = costo;
        DuracionMeses = 1;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Calcula el costo final de la inscripción.
    /// Regla de negocio: si la duración es mayor a 6 meses, aplica descuento.
    /// </summary>
    /// <returns>Costo final</returns>
    public double CalcularCosto()
    {
        double total = costo;

        // Regla de negocio: descuento por duración larga
        if (duracionMeses > 6)
        {
            total -= (total * DESCUENTO);
        }

        return total;
    }

    /// <summary>
    /// Muestra la información de la inscripción
    /// </summary>
    public void MostrarInscripcion()
    {
        Console.WriteLine("===== DETALLE DE INSCRIPCIÓN =====");
        Console.WriteLine($"Estudiante: {Estudiante}");
        Console.WriteLine($"Costo base: {Costo:C}");
        Console.WriteLine($"Duración (meses): {DuracionMeses}");
        Console.WriteLine($"Fecha: {Fecha.ToShortDateString()}");
        Console.WriteLine($"Costo final: {CalcularCosto():C}");
    }
}

