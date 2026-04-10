var cuenta = new CuentaBancaria("María Gómez");

// Intento de acceso directo: ¡ERROR DE COMPILACIÓN!
// cuenta.Saldo = 1000; // <--- CS0200: Property or indexer 'CuentaBancariaSegura.Saldo' cannot be assigned to -- it is read only

// Intento de cambiar nombre: ¡ERROR DE COMPILACIÓN!
// cuenta.NombreTitular = "Hacker"; // <--- CS0272: The property 'CuentaBancariaSegura.NombreTitular' has no setter.

// Interacción correcta a través de la Interfaz Pública (La Caja Negra - Página 5)
cuenta.Depositar(1500.50m);
cuenta.Retirar(200.00m);

try
{
    // Intento de corrupción detenido por la validación del método (Página 8)
    cuenta.Retirar(-500); // Lanza ArgumentException
}
catch (ArgumentException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ALERTA DE SEGURIDAD: {ex.Message}");
    Console.ResetColor();
}

// Consulta segura del estado (Solo lectura)
Console.WriteLine($"Saldo final: ${cuenta.Saldo:N2}");
