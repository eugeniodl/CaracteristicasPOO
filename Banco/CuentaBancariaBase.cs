public class CuentaBancariaBase
{
    private decimal _saldo;
    private readonly string _numeroCuenta;

    public CuentaBancariaBase(string numeroCuenta,
        decimal saldoInicial = 0)
    {
        _numeroCuenta = numeroCuenta ?? 
            throw new ArgumentNullException
            (nameof(numeroCuenta));
        _saldo = saldoInicial >= 0 ? saldoInicial :
            throw new ArgumentException
            ("Saldo inicial no puede ser negativo");
    }

    public decimal Saldo => _saldo;
    public string NumeroCuenta => _numeroCuenta;

    public virtual void Depositar(decimal monto)
    {
        if (monto <= 0) throw new ArgumentException
                ("Monto debe ser positivo.");
        _saldo += monto;
        RegistrarTrasanccion("DEPÓSITO", monto);
    }

    protected virtual void AcreditarInterno(decimal monto,
        string concepto)
    {
        if (monto <= 0) throw new ArgumentException
                ("Monto de crédito interno inválido");

        decimal impuesto = monto * 0.01m;
        decimal montoNeto = monto - impuesto;

        _saldo += montoNeto;
        RegistrarTrasanccion($"BENEFICIO ({concepto}) " +
            $"- Impuesto: {impuesto:C}", montoNeto);

        Console.WriteLine($"[Lógica Base]" +
            $" Impuesto aplicado: {impuesto:C}. " +
            $"Neto acreditado: {montoNeto:C}");
    }

    protected virtual void DebitarInterno(decimal monto,
        string concepto)
    {
        if (monto <= 0) throw new ArgumentException
                ("Monto inválido.");
        if (monto > _saldo) throw
                new InvalidOperationException
                ("Fondos insuficientes.");
        _saldo -= monto;
        RegistrarTrasanccion($"DEBITO ({concepto})",
            -monto);
    }

    private void RegistrarTrasanccion(string tipo, 
        decimal monto)
    {
        Console.WriteLine($"[AUDITORÍA] {tipo}: {monto:C}. " +
            $"Saldo resultante: {Saldo:C}");
    }
}
