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

    private void RegistrarTransaccion(string tipo, decimal monto)
    {
        Console.WriteLine($"[AUDITORÍA] {tipo}: {monto:C}. " +
            $"Saldo resultante: {Saldo:C}");
    }
}
