var motor = new ConfiguracionMotor(500, 25);

// motor.TemperaturaCelsius = 30;

motor.ActualizarLecturaSensor(85);
motor.AplicarAceleracion();

try
{
	motor.ActualizarLecturaSensor(-200);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Protección activada: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error no controlado: {ex.Message}");
}