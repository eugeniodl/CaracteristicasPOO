public class CuentaBancaria
{
    private string? _numeroCuenta;
    private decimal _saldo;

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
        if(monto > 0 && monto <= Saldo)
        {
            Saldo -= monto;
            Console.WriteLine($"Retiro: {monto:C}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes o monto inválido.");
        }
    }

    public string? NumeroCuenta { get => _numeroCuenta; set => _numeroCuenta = value; }
    public decimal Saldo { get => _saldo; set => _saldo = value; }
}


