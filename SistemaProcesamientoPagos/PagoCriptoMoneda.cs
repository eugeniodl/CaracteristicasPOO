public sealed class PagoCriptoMoneda : MetodoPago
{
    private string? _direccionWallet;

    private string? DireccionWallet
    {
        get => _direccionWallet;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("La dirección de wallet es requerida");
            if (!value.StartsWith("0x") &&
                !value.StartsWith("bc1") && !value.StartsWith("1"))
                throw new ArgumentException
                    ("Formato de wallet inválido");
            if (value.Length < 26 || value.Length > 42)
                throw new ArgumentException
                    ("Longitud de wallet inválida");
            _direccionWallet = value;
        }
    }

    public PagoCriptoMoneda(string moneda, 
        decimal montoBase,
        string? direccionWallet) : base(moneda, montoBase)
    {
        DireccionWallet = direccionWallet;
    }

    public override decimal CalcularComision()
    {
        return 0.001m * MontoBase; //0.1%
    }

    public override sealed string ObtenerDescripcion()
    {
        string walletMask = _direccionWallet?.Length > 8
            ? _direccionWallet[..6] + "..." +
            _direccionWallet[^4..] : "****";
        return $"Cripto a {walletMask} - " +
            $"Comisión: {CalcularComision():C}";
    }
}

