public class CuentaBancaria
{
    private decimal _saldo;

    public string NumeroCuenta { get; }

    public decimal Saldo
    {
        get { return _saldo; }
    }

    public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
    {
        NumeroCuenta = numeroCuenta;
        _saldo = saldoInicial;
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            _saldo += monto;
            Console.WriteLine($"Depósito: {monto:C}");
        }
        else
        {
            Console.WriteLine("Monto inválido para depósito.");
        }
    }

    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= _saldo)
        {
            _saldo -= monto;
            Console.WriteLine($"Retiro: {monto:C}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes o monto inválido.");
        }
    }
}


