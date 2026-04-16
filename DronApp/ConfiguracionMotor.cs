// Código bajo análisis crítico (Caso #1)
public class ConfiguracionMotor
{
    private int _potenciaMaximaWatts;
    private double _temperaturaActualKelvin;
    private const double CELSIUS_TO_KELVIN_OFFSET = 273.15;

    public ConfiguracionMotor(int potenciaMaximaWatts, 
        double temperaturaInicialCelsius)
    {
        if(potenciaMaximaWatts <= 0)
            throw new ArgumentException("La potencia debe ser positiva.",
                nameof(potenciaMaximaWatts));
        if(temperaturaInicialCelsius < -50 ||
            temperaturaInicialCelsius > 100)
            throw new ArgumentException("Temperatura fuera de rango.", 
                nameof(temperaturaInicialCelsius));

        _potenciaMaximaWatts = potenciaMaximaWatts;
        _temperaturaActualKelvin = ConvertirCelsiusAKelvin
            (temperaturaInicialCelsius);
    }

    private double ConvertirCelsiusAKelvin(double celsius)
    {
        return celsius + CELSIUS_TO_KELVIN_OFFSET;
    }

    private double ConvertirKelvinACelsius(double kelvin) => 
        kelvin - CELSIUS_TO_KELVIN_OFFSET;

    public int PotenciaMaximaWatts
    {
        get => _potenciaMaximaWatts;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Potencia inválida.");
            _potenciaMaximaWatts = value;
        }
    }
    public double TemperaturaCelsius
    {
        get => ConvertirKelvinACelsius(_temperaturaActualKelvin);
        private set
        {
            if (value < -50 || value > 150)
                throw new ArgumentException("Temperatura fuera de rango.");
            _temperaturaActualKelvin = ConvertirCelsiusAKelvin(value);
        }
    }

    public void ActualizarLecturaSensor(double nuevaTemperaturaCelsius)
    {
        Console.WriteLine($"[Sensor] Lectura recibida: " +
            $"{nuevaTemperaturaCelsius} °C");
        TemperaturaCelsius = nuevaTemperaturaCelsius;
    }

    public void AplicarAceleracion()
    {
        if (TemperaturaCelsius > 80)
        {
            Console.WriteLine("¡ADVERTENCIA! Sobrecalentamiento. " +
                "Limitando potencia.");
            // Lógica de protección...
        }
        else
        {
            Console.WriteLine("Aplicando potencia máxima: " +
                $"{PotenciaMaximaWatts} W");
        }
    }
}