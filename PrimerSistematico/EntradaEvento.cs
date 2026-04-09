/// <summary>
/// Clase que representa la venta de entradas para un evento.
/// </summary>
public class EntradaEvento
{
    // Atributos privados (encapsulamiento)
    private string cliente;
    private int cantidad;
    private double precio;
    private DateTime fecha;

    // Constante de impuesto (15%)
    private const double IMPUESTO = 0.15;

    // Propiedades públicas
    public string Cliente
    {
        get { return cliente; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");
            cliente = value;
        }
    }

    public int Cantidad
    {
        get { return cantidad; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            cantidad = value;
        }
    }

    public double Precio
    {
        get { return precio; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            precio = value;
        }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        set
        {
            if (value < DateTime.Now.Date)
                throw new ArgumentException("La fecha no puede ser anterior a hoy.");
            fecha = value;
        }
    }

    /// <summary>
    /// Constructor principal
    /// </summary>
    public EntradaEvento(string cliente, int cantidad, double precio)
    {
        Cliente = cliente;
        Cantidad = cantidad;
        Precio = precio;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Constructor alternativo (cantidad por defecto = 1)
    /// </summary>
    public EntradaEvento(string cliente, double precio)
    {
        Cliente = cliente;
        Cantidad = 1;
        Precio = precio;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Calcula el total a pagar incluyendo impuesto.
    /// Regla de negocio: descuento del 10% si compra más de 5 entradas.
    /// </summary>
    public double CalcularTotal()
    {
        double subtotal = cantidad * precio;

        // Regla de negocio: descuento
        if (cantidad > 5)
        {
            subtotal *= 0.90; // 10% de descuento
        }

        double total = subtotal + (subtotal * IMPUESTO);
        return total;
    }

    /// <summary>
    /// Muestra la información de la entrada
    /// </summary>
    public void MostrarEntrada()
    {
        Console.WriteLine("===== DETALLE DE ENTRADA =====");
        Console.WriteLine($"Cliente: {Cliente}");
        Console.WriteLine($"Cantidad: {Cantidad}");
        Console.WriteLine($"Precio unitario: {Precio:C}");
        Console.WriteLine($"Fecha: {Fecha.ToShortDateString()}");
        Console.WriteLine($"Total a pagar: {CalcularTotal():C}");
    }
}
