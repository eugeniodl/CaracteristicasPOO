CuentaBancaria cuenta = new CuentaBancaria("123456789", 1000m);

var transacciones = new Transaccion[]
{
    new Deposito(cuenta, 500m),
    new Retiro(cuenta, 200m),
    new Deposito(cuenta, 300m),
    new Retiro(cuenta, 1500m) // Intento de retiro con saldo insuficiente
};

foreach (var transaccion in transacciones)
{
    transaccion.Ejecutar();
    Console.WriteLine($"Saldo actual: {cuenta.Saldo:C}");
}