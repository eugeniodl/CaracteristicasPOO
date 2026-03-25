public abstract class Transaccion
{
    protected CuentaBancaria? cuenta;
    protected decimal monto;

    public Transaccion(CuentaBancaria? cuenta, decimal monto)
    {
        this.cuenta = cuenta;
        this.monto = monto;
    }

    public abstract void Ejecutar();
}