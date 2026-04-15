/// <summary>
/// Clase que representa una cuenta bancaria con funcionalidades básicas como depósito, retiro y consulta de saldo.
/// </summary>
public class CuentaBancaria
{
    private decimal _saldo;
    private bool _estadoActivo;

    public decimal Saldo
    {
        get { return _saldo; }
        private set { _saldo = value; }
    }

    public string NombreTitular { get; private set; }

    public bool EstadoActivo
    {
        get { return _estadoActivo; }
        private set { _estadoActivo = value; }
    }

    public CuentaBancaria(string nombreTitular)
    {
        NombreTitular = nombreTitular;
        Saldo = 0m;
        EstadoActivo = true;
    }

    public void Depositar(decimal monto)
    {
        if(!EstadoActivo)
            throw new InvalidOperationException("La cuenta está inactiva. No se pueden realizar depósitos.");

        if (monto <= 0)
            throw new ArgumentException("El monto a depositar debe ser mayor que cero.");

        Saldo += monto;
        Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${Saldo:N2}");
    }

    public void Retirar(decimal monto)
    {
        if(!EstadoActivo)
            throw new InvalidOperationException("La cuenta está inactiva. No se pueden realizar retiros.");
        if (monto <= 0)
            throw new ArgumentException("El monto a retirar debe ser mayor que cero.");
        if (monto > Saldo)
            throw new InvalidOperationException("Fondos insuficientes para realizar el retiro.");
        Saldo -= monto;
        Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${Saldo:N2}");
    }
}