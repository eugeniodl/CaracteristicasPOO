public class PagoTransferenciaBancaria : MetodoPago
{
    public PagoTransferenciaBancaria(string moneda, 
        decimal montoBase) : base(moneda, montoBase)
    {
    }

    public override decimal CalcularComision()
    {
        return 5.99m; // Comisión fija
    }

    public override sealed string ObtenerDescripcion()
    {
        return $"Transferencia bancaria - " +
            $"Comisión fija: {CalcularComision():C}";
    }
}

