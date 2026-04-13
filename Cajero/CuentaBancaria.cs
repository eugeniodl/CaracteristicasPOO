/// <summary>
/// Clase que cumple con el principio de Encapsulación
/// </summary>

public class CuentaBancaria
{
    private decimal _saldo;
    private string _nombreTitular;
    private bool _estadoActivo; 

    public decimal Saldo
    {
        get { return _saldo; }
        private set { _saldo = value; }
    }


    public void Depositar(decimal monto)
    {
        if (!EstadoActivo)
        {
            throw new InvalidOperationException("No se puede operar una cuenta inactiva.");
        }

        if (monto <= 0)
            throw new ArgumentException("El monto a depositar debe ser positivo.",
                nameof(monto));

        Saldo += monto;
        Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${Saldo:N2}");

    }

    public void Retirar(decimal monto)
    {
        if (!EstadoActivo)
            throw new InvalidOperationException("Cuenta inactiva.");

        if(monto <= 0)
            throw new ArgumentException("Monto inválido.", nameof(monto));

        if (monto > Saldo)
            throw new InvalidOperationException($"Fondos insuficientes. " +
                $"Saldo actual: ${Saldo:N2}");

        Saldo -= monto;
        Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${Saldo:N2}");
    }

    public string NombreTitular
    {
        get => _nombreTitular; 
        private set { _nombreTitular = value; }
    }

    public bool EstadoActivo
    {
        get => _estadoActivo;
        private set { _estadoActivo = value; }
    }

    public CuentaBancaria(string nombreTitular)
    {
        NombreTitular = nombreTitular;
        Saldo = 0m;
        EstadoActivo = true;
    }
}
