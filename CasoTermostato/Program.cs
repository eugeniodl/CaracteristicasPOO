var miTermostato = new Termostato(30.0);

//miTermostato.TemperaturaObjetivo = 36.0; // CS0200

Console.WriteLine($"Temperatura inicial: {miTermostato.TemperaturaObjetivo:F1}°C");
Console.WriteLine("--------- Subiendo temperatura normalmente ---------------");
miTermostato.SubirTemperatura();  // 30.0 + 0.5 = 30.5
miTermostato.SubirTemperatura();  // 30.5 + 0.5 = 31.0
Console.WriteLine($"Temperatura actual: {miTermostato.TemperaturaObjetivo:F1}°C");

for (int i = 1; i <= 10; i++)
{
	try
	{
		Console.WriteLine($" Intento #{i}");
		miTermostato.SubirTemperatura();
		Console.WriteLine("Éxito");
	}
	catch (InvalidOperationException ex)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine($"BLOQUEADO: {ex.Message}");
		Console.ResetColor();
		break;
    }
	catch (Exception ex)
	{
		Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR INESPERADO: {ex.Message}");
		Console.ResetColor();
		break;
    }
}
Console.WriteLine("\n3. Estado final del sistema");
Console.WriteLine($"Temperatura: {miTermostato.TemperaturaObjetivo:F1}°C");
Console.WriteLine("El sistema sigue funcionando con normalidad.");
