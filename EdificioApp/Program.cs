var miTermostato = new Termostato(30.0);

Console.WriteLine($"Temperatura inicial: {miTermostato.TemperaturaObjetivo:F1}°C");

miTermostato.SubirTemperatura();
miTermostato.SubirTemperatura();
miTermostato.SubirTemperatura();

Console.WriteLine("2. Simulación un ataque de fuerza bruta");

for(int i = 1; i <= 10; i++)
{
    try
    {
        Console.WriteLine($"Intento #{i}: ");
        miTermostato.SubirTemperatura();
        Console.WriteLine("Éxito");
    }
    catch(InvalidOperationException ex)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"BLOQUEADO {ex.Message}");
        Console.ResetColor();
        break;
    }
    catch(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR] Ocurrió un error inesperado: {ex.Message}");
        Console.ResetColor();
        break;
    }
}

Console.WriteLine($"\n3. Estado final del sistema");
Console.WriteLine($"Temperatura final: {miTermostato.TemperaturaObjetivo:F1}°C");