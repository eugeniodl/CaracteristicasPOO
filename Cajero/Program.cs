var cuenta = new CuentaBancaria("Juan Pérez");

//cuenta.Saldo = 1000m; // CS0122: No se puede asignar a 'Saldo' porque es un miembro de solo lectura

//cuenta.Saldo = -99999m;

try
{
    cuenta.Depositar(1000m);
    cuenta.Retirar(500m);
    cuenta.Depositar(-100m);
}
catch (ArgumentException ex)
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine($"ALERTA DE SEGURIDAD: {ex.Message}");
	Console.ResetColor();
}

Console.WriteLine($"Saldo final: ${cuenta.Saldo:N2}");
