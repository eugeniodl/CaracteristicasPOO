/// <summary>
/// Clase que representa el pago de un empleado.
/// </summary>
public class PagoEmpleado
{
    // Atributos privados
    private string nombre;
    private int horasTrabajadas;
    private double pagoPorHora;
    private DateTime fecha;

    // Constante para horas extra (50% adicional)
    private const double FACTOR_EXTRA = 1.5;

    // Propiedades públicas con validación
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            nombre = value;
        }
    }

    public int HorasTrabajadas
    {
        get { return horasTrabajadas; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Las horas trabajadas deben ser mayores que cero.");
            horasTrabajadas = value;
        }
    }

    public double PagoPorHora
    {
        get { return pagoPorHora; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El pago por hora debe ser mayor que cero.");
            pagoPorHora = value;
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
    public PagoEmpleado(string nombre, int horasTrabajadas, double pagoPorHora)
    {
        Nombre = nombre;
        HorasTrabajadas = horasTrabajadas;
        PagoPorHora = pagoPorHora;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Constructor alternativo (8 horas por defecto)
    /// </summary>
    public PagoEmpleado(string nombre, double pagoPorHora)
    {
        Nombre = nombre;
        HorasTrabajadas = 8; // jornada estándar
        PagoPorHora = pagoPorHora;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Calcula el salario del empleado.
    /// Regla de negocio: las horas mayores a 40 se pagan como extra.
    /// </summary>
    /// <returns>Total a pagar</returns>
    public double CalcularPago()
    {
        double salario;

        if (horasTrabajadas <= 40)
        {
            salario = horasTrabajadas * pagoPorHora;
        }
        else
        {
            int horasNormales = 40;
            int horasExtra = horasTrabajadas - 40;

            salario = (horasNormales * pagoPorHora) +
                      (horasExtra * pagoPorHora * FACTOR_EXTRA);
        }

        return salario;
    }

    /// <summary>
    /// Muestra la información del pago
    /// </summary>
    public void MostrarPago()
    {
        Console.WriteLine("===== DETALLE DE PAGO =====");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Horas trabajadas: {HorasTrabajadas}");
        Console.WriteLine($"Pago por hora: {PagoPorHora:C}");
        Console.WriteLine($"Fecha: {Fecha.ToShortDateString()}");
        Console.WriteLine($"Salario total: {CalcularPago():C}");
    }
}

