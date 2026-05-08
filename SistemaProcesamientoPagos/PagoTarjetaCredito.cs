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
            if(value.Length < 13 || value.Length > 19)
                throw new ArgumentException
                    ("Número de tarjeta inválido");
            _numeroTarjeta = value;
        }
    }


    public PagoTarjetaCredito(string moneda, 
        decimal montoBase) : base(moneda, montoBase)
    {
    }
}
