public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string numeroCuenta, decimal saldo)
        : base(numeroCuenta, saldo)
    {
    }

    public override void Retirar(decimal monto)
    {
        if (Saldo >= monto)
        {
            Saldo -= monto;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para retirar.");
        }
    }
}

