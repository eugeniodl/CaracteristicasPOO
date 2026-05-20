public sealed class PagoCriptomenda : MetodoPago
{
    private string? _direccionWallet;

    private string? DireccionWallet
    {
        get => _direccionWallet;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException
                    ("Dirección de wallet requerida");
            if (value.Length < 26 || value.Length > 35)
                throw new ArgumentException
                    ("Dirección de wallet inválida");
            if(!value.StartsWith("0x") && !value.StartsWith("bc1") 
                && !value.StartsWith("1"))
                throw new ArgumentException
                    ("Formato de wallet inválido");
            _direccionWallet = value;
        }
    }

    public PagoCriptomenda(string moneda, 
        decimal montoBase, string? direccionWallet) : base(moneda, montoBase)
    {
        DireccionWallet = direccionWallet;
    }

    public override decimal CalcularComision()
    {
        return MontoBase * 0.001m; // 0.1% de comisión para criptomonedas
    }

    public sealed override string ObtenerDescripcion()
    {
        string walletMask = DireccionWallet?.Length > 8 ? DireccionWallet[..6]
            + "..." + DireccionWallet[^4..] : "****";
        return $"Cripto a {walletMask} - Comisión: {CalcularComision():C}";
    }
}

