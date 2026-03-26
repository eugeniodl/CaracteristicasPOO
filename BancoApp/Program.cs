CuentaBancaria cuenta = 
    new CuentaBancaria("123456", 1000m);

Transaccion[] transacciones = new Transaccion[4];

transacciones[0] = new Deposito(cuenta, 500);
transacciones[1] = new Retiro(cuenta, 200);
transacciones[2] = new Retiro(cuenta, 1500); // inválido
transacciones[3] = new Deposito(cuenta, 300);

Console.WriteLine("===== INICIO DE TRANSACCIONES =====");

for (int i = 0; i < transacciones.Length; i++)
{
    transacciones[i].Ejecutar();
    Console.WriteLine($"Saldo actual: {cuenta.Saldo:C}\n");
}

Console.WriteLine("=== FIN ===");