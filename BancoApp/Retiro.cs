public class Retiro : Transaccion
{
    public Retiro(CuentaBancaria? cuenta, 
        decimal monto) : base(cuenta, monto)
    {
    }

    public override void Ejecutar()
    {
        Console.WriteLine("Procesando retiro...");
        cuenta?.Retirar(monto);
    }
}

