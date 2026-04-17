var motor = new ConfiguracionMotor(500, 25);

// motor.TemperaturaCelsius = 85;

motor.ActualizarLecturaSensor(85);
motor.AplicarAceleracion();

try
{
	motor.ActualizarLecturaSensor(-200);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Protección activa: {ex.Message}");
}

Console.WriteLine($"Estado final: {motor.TemperaturaCelsius:F1}°C");