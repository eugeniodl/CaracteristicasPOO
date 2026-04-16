var motor = new ConfiguracionMotor(200, 25);

try
{
	//motor.TemperaturaCelsius = 200; // CS0272
    motor.ActualizarLecturaSensor(30); // Vía correcta
	motor.AplicarAceleracion();
	motor.ActualizarLecturaSensor(-120); // Vía correcta
    
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Protección activa: {ex.Message}");
}
catch (ArgumentException ex)
{
	Console.WriteLine($"Error de configuración: {ex.Message}");
}
catch (Exception ex)
{
	Console.WriteLine($"Error inesperado: {ex.Message}");
}
Console.WriteLine($"Estado final: {motor.TemperaturaCelsius:F}°C");

