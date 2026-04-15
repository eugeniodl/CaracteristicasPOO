public class ConfiguracionMotor
{
    // El desarrollador dijo: "Es solo una estructura de datos, no necesito propiedades"
    public int PotenciaMaxima; // En vatios
    public int TemperaturaActual; // En Celsius

    public void AplicarAceleracion()
    {
        if (TemperaturaActual > 80)
        {
            Console.WriteLine("¡PELIGRO! Sobrecalentamiento.");
            // Lógica de emergencia...
        }
        // Lógica de vuelo...
    }
}

