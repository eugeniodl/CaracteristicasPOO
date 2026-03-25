public class CuentaBancaria
{
    private decimal _saldo;
    private string? _numeroCuenta;

    public CuentaBancaria(string? numeroCuenta, decimal saldo)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            Saldo += monto;
            Console.WriteLine($"Depósito: {monto:C}");
        }
        else
        {
            Console.WriteLine("Monto inválido para depósito");
        }
    }

    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= Saldo)
        {
            Saldo -= monto;
            Console.WriteLine($"Retiro: {monto:C}");
        }
        else
        {
            Console.WriteLine("Monto inválido para retiro o saldo insuficiente");
        }
    }

    public decimal Saldo { get => _saldo; set => _saldo = value; }
    public string? NumeroCuenta { get => _numeroCuenta; set => _numeroCuenta = value; }
}

