class CuentaBancaria
{
    private decimal _saldo;
    private string? _numeroCuenta;

    public CuentaBancaria(decimal saldo, string? numeroCuenta)
    {
        Saldo = saldo;
        NumeroCuenta = numeroCuenta;
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

    public decimal Saldo { get => _saldo; set => _saldo = value; }
    public string? NumeroCuenta { get => _numeroCuenta; set => _numeroCuenta = value; }
}


