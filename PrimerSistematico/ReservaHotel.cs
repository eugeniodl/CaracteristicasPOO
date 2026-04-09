/// <summary>
/// Clase que representa una reserva de hotel.
/// </summary>
public class ReservaHotel
{
    // Atributos privados
    private string nombreCliente;
    private int cantidadNoches;
    private double precioPorNoche;
    private DateTime fechaReserva;

    // Constante de impuesto (15%)
    private const double IMPUESTO = 0.15;

    // Propiedades públicas con validación
    public string NombreCliente
    {
        get { return nombreCliente; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");
            nombreCliente = value;
        }
    }

    public int CantidadNoches
    {
        get { return cantidadNoches; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("La cantidad de noches debe ser mayor que cero.");
            cantidadNoches = value;
        }
    }

    public double PrecioPorNoche
    {
        get { return precioPorNoche; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El precio por noche debe ser mayor que cero.");
            precioPorNoche = value;
        }
    }

    public DateTime FechaReserva
    {
        get { return fechaReserva; }
        set
        {
            if (value < DateTime.Now.Date)
                throw new ArgumentException("La fecha de reserva no puede ser anterior a hoy.");
            fechaReserva = value;
        }
    }

    /// <summary>
    /// Constructor principal
    /// </summary>
    public ReservaHotel(string nombreCliente, int cantidadNoches, double precioPorNoche)
    {
        NombreCliente = nombreCliente;
        CantidadNoches = cantidadNoches;
        PrecioPorNoche = precioPorNoche;
        FechaReserva = DateTime.Now;
    }

    /// <summary>
    /// Constructor sobrecargado (1 noche por defecto)
    /// </summary>
    public ReservaHotel(string nombreCliente, double precioPorNoche)
    {
        NombreCliente = nombreCliente;
        CantidadNoches = 1;
        PrecioPorNoche = precioPorNoche;
        FechaReserva = DateTime.Now;
    }

    /// <summary>
    /// Calcula el total de la reserva incluyendo impuesto.
    /// Regla de negocio: descuento del 15% si reserva más de 7 noches.
    /// </summary>
    /// <returns>Total a pagar</returns>
    public double CalcularTotal()
    {
        double subtotal = cantidadNoches * precioPorNoche;

        // Regla de negocio: descuento por larga estadía
        if (cantidadNoches > 7)
        {
            subtotal *= 0.85; // 15% de descuento
        }

        double total = subtotal + (subtotal * IMPUESTO);
        return total;
    }

    /// <summary>
    /// Muestra la información de la reserva en consola
    /// </summary>
    public void MostrarReserva()
    {
        Console.WriteLine("===== DETALLE DE RESERVA =====");
        Console.WriteLine($"Cliente: {NombreCliente}");
        Console.WriteLine($"Noches: {CantidadNoches}");
        Console.WriteLine($"Precio por noche: {PrecioPorNoche:C}");
        Console.WriteLine($"Fecha de reserva: {FechaReserva.ToShortDateString()}");
        Console.WriteLine($"Total a pagar: {CalcularTotal():C}");
    }
}



