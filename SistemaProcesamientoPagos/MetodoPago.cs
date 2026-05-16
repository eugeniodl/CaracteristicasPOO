public abstract class MetodoPago
{
    private string? _moneda;
    private decimal _montoBase;

    public string? Moneda
    {
        get => _moneda;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("Moneda requerida");
            _moneda = value.ToUpper();
        }
    }

    public decimal MontoBase
    {
        get => _montoBase;
        set
        {
            if (value <= 0)
                throw new ArgumentException
            ("El monto debe ser mayor a cero");
            _montoBase = value;
        }
    }

    protected MetodoPago(string moneda,
        decimal montoBase)
    {
        Moneda = moneda;
        MontoBase = montoBase;
    }

    public abstract decimal CalcularComision();

    public virtual string ObtenerDescripcion()
    {
        return $"Pago en {Moneda} por {MontoBase:C}";
    }

    public decimal CalcularTotal()
    {
        return MontoBase + CalcularComision();
    }

    public decimal CalcularTotal
        (decimal impuestoAdicional)
    {
        return CalcularTotal() + impuestoAdicional;
    }
}

