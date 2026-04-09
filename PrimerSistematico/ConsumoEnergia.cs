/// <summary>
/// Clase que representa el consumo eléctrico de un cliente.
/// </summary>
public class ConsumoEnergia
{
    // Atributos privados
    private string cliente;
    private double consumoKwh;
    private double costoPorKwh;
    private DateTime fecha;

    // Constante de recargo (20%)
    private const double RECARGO_ALTO = 0.20;

    // Propiedades públicas con validación
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

    public double ConsumoKwh
    {
        get { return consumoKwh; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El consumo debe ser mayor que cero.");
            consumoKwh = value;
        }
    }

    public double CostoPorKwh
    {
        get { return costoPorKwh; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("El costo por kWh debe ser mayor que cero.");
            costoPorKwh = value;
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
    public ConsumoEnergia(string cliente, double consumoKwh, double costoPorKwh)
    {
        Cliente = cliente;
        ConsumoKwh = consumoKwh;
        CostoPorKwh = costoPorKwh;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Constructor sobrecargado (consumo por defecto: 100 kWh)
    /// </summary>
    public ConsumoEnergia(string cliente, double costoPorKwh)
    {
        Cliente = cliente;
        ConsumoKwh = 100; // valor estimado
        CostoPorKwh = costoPorKwh;
        Fecha = DateTime.Now;
    }

    /// <summary>
    /// Calcula el total a pagar.
    /// Regla de negocio: si el consumo supera 300 kWh, aplica recargo.
    /// </summary>
    /// <returns>Total a pagar</returns>
    public double CalcularTotal()
    {
        double total = consumoKwh * costoPorKwh;

        // Regla de negocio: recargo por alto consumo
        if (consumoKwh > 300)
        {
            total += total * RECARGO_ALTO;
        }

        return total;
    }

    /// <summary>
    /// Muestra la información del consumo
    /// </summary>
    public void MostrarConsumo()
    {
        Console.WriteLine("===== DETALLE DE CONSUMO ELÉCTRICO =====");
        Console.WriteLine($"Cliente: {Cliente}");
        Console.WriteLine($"Consumo (kWh): {ConsumoKwh}");
        Console.WriteLine($"Costo por kWh: {CostoPorKwh:C}");
        Console.WriteLine($"Fecha: {Fecha.ToShortDateString()}");
        Console.WriteLine($"Total a pagar: {CalcularTotal():C}");
    }
}
