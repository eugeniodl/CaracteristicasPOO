public abstract class Cuenta
{
    private string _numeroCuenta;
    private decimal _saldo;

    protected Cuenta(string numeroCuenta, decimal saldo)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    public string NumeroCuenta { get => _numeroCuenta; set => _numeroCuenta = value; }
    public decimal Saldo { get => _saldo; set => _saldo = value; }


    public void Depositar(decimal monto)
    {
        Saldo += monto;
    }

    public abstract void Retirar(decimal monto);

    public decimal ConsultarSaldo()
    {
        return Saldo;
    }
}

