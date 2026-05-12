public class PagoTarjetaCredito : MetodoPago
{
    private string? _numeroTarjeta;

    private string? NumeroTarjeta
    {
        get => _numeroTarjeta;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("Número de tarjeta requerido");
            if (value.Length < 13 || value.Length > 19)
                throw new ArgumentException
                    ("Número de tarjeta inválido");
            _numeroTarjeta = EnmascararTarjeta(value);
        }
    }

    public PagoTarjetaCredito(string moneda,
        decimal montoBase, string numeroTarjeta) 
        : base(moneda, montoBase)
    {
        NumeroTarjeta = numeroTarjeta;
    }

    public override decimal CalcularComision()
    {
        return MontoBase * 0.03m; // 3% de comisión
    }

    public override string ObtenerDescripcion()
    {
        return $"Tarjeta terminada en {_numeroTarjeta} " +
            $"- Comisión: {CalcularComision():C}";
    }

    private string? EnmascararTarjeta(string numero)
    {
        if (numero.Length <= 4) return "****";
        return "****" + numero.Substring(numero.Length - 4);
    }
}

