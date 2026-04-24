public class CuentaBancariaBase
{
    private decimal _saldo;
    private readonly string _numeroCuenta;

    public CuentaBancariaBase(string numeroCuenta,
        decimal saldoInicial = 0)
    {
        _numeroCuenta = numeroCuenta ??
            throw new ArgumentNullException(nameof(numeroCuenta));
        _saldo = saldoInicial >= 0 ? saldoInicial : 
            throw new ArgumentException
            ("Saldo inicial no puede ser negativo");
    }

    public decimal Saldo => _saldo;
    public string NumeroCuenta => _numeroCuenta;

    public virtual void Depositar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("Monto debe ser " +
                "positivo.");
        _saldo += monto;
        RegistrarTransaccion("DEPÓSITO", monto);
    }

    /// <summary>
    /// Permite a las clases derivadas acreditar fondos de forma segura, 
    /// garantizando que se aplique la lógica de negocio base (ej: impuestos, 
    /// auditoría)
    /// </summary>
    /// <param name="monto">Monto a acreditar</param>
    /// <param name="concepto">Razón del crédito interno</param>
    protected virtual void AcreditarInterno(decimal monto,
        string concepto)
    {
        if (monto <= 0) throw new ArgumentException("Monto de crédito interno " +
            "inválido");
        decimal impuesto = monto * 0.01m;
        decimal montoNeto = monto - impuesto;

        _saldo += montoNeto;
        RegistrarTransaccion($"BENEFICIO ({concepto}) - Impuesto: {impuesto:C}", 
            montoNeto);

        Console.WriteLine($" [Lógica Base] Impuesto aplicado: {impuesto:C}. " +
            $"Neto acreditado: {montoNeto:C}");
    }

    protected virtual void DebitarInterno(decimal monto, string concepto)
    {
        if (monto <= 0) throw new ArgumentException("Monto inválido.");
        if (monto > _saldo) throw new InvalidOperationException
                ("Fondos insuficientes.");
        _saldo -= monto;
        RegistrarTransaccion($"DÉBITO ({concepto})", -monto);
    }

    private void RegistrarTransaccion(string tipo, decimal monto)
    {
        Console.WriteLine($"[AUDITORÍA] {tipo}: {monto:C}. " +
            $"Saldo resultante: {Saldo:C}");
    }
}
