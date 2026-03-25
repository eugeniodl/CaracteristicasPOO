public class Deposito : Transaccion
{
    public Deposito(CuentaBancaria? cuenta, decimal monto)
        : base(cuenta, monto)
    {
    }

    public override void Ejecutar()
    {
        Console.WriteLine("Procesando depósito...");
        cuenta?.Depositar(monto);
    }
}

