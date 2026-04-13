var cuenta = new CuentaBancaria("Juan Pérez");

// cuenta.Saldo = 5000;

// cuenta.Saldo = -999999;

try
{
	cuenta.Depositar(1500.50m);
	cuenta.Retirar(200.00m);

	cuenta.Retirar(-500);
}
catch (ArgumentException ex)
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine($"ALERTA DE SEGURIDAD: {ex.Message}");
	Console.ResetColor();
}

Console.WriteLine($"Saldo final: ${cuenta.Saldo:N2}");
