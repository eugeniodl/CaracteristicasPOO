var miTermostato = new Termostato(30.0);
Console.WriteLine($"Temperatura inicial: {miTermostato.TemperaturaObjetivo}°C\n");

// miTermostato.TemperaturaObjetivo = 30; // CS0200

Console.WriteLine("--- Subiendo temperatura normalmente ---");
miTermostato.SubirTemperatura();
miTermostato.SubirTemperatura();
Console.WriteLine($" Temperatura actual: {miTermostato.TemperaturaObjetivo:F1}°C\n");

Console.WriteLine("2. Simulando un ataque de fuerza bruta:");
Console.WriteLine("(El sistema de protege a sí mismo y el cliente maneja el error)\n");

for (int i = 1; i <= 10; i++)
{
    try
    {
        Console.WriteLine($"Intento #{i}:");
        miTermostato.SubirTemperatura();
        Console.WriteLine("Éxito");
    }
    catch (InvalidOperationException ex)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
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

Console.WriteLine($"\n3. Estado final del sistema:");
Console.WriteLine($"Temperatura: {miTermostato.TemperaturaObjetivo:F1}°C");
