public class ConfiguracionMotor
{
    private double _temperaturaKelvin;
    private int _potenciaMaximaWatts;
    private const double CELSIUS_TO_KELVIN_OFFSET = 273.15;

    public ConfiguracionMotor(int potenciaMaximaWatts, int temperaturaCelsius)
    {
        if(potenciaMaximaWatts <= 0)
        {
            throw new ArgumentException
                ("La potencia máxima debe ser un valor positivo.");
        }
        if(temperaturaCelsius < -50 || temperaturaCelsius > 100)
        {
            throw new ArgumentException
                ("La temperatura inicial está fuera del rango permitido.");
        }

        _potenciaMaximaWatts = potenciaMaximaWatts;
        _temperaturaKelvin = ConvertirCelsiusAKelvin(temperaturaCelsius);
    }

    private double ConvertirCelsiusAKelvin(double celsius) => 
        celsius + CELSIUS_TO_KELVIN_OFFSET;

    private double ConvertirKelvinACelsius(double kelvin) => 
        kelvin - CELSIUS_TO_KELVIN_OFFSET;

    public int PotenciaMaximaWatts
    {
        get => _potenciaMaximaWatts;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException
                    ("La potencia máxima debe ser un valor positivo.");
            }
            _potenciaMaximaWatts = value;
        }
    }
    public double TemperaturaCelsius
    {
        get => ConvertirKelvinACelsius(_temperaturaKelvin);
        private set
        {
            if (value < -50 || value > 150)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Temperatura fuera de rango seguro.");
            }
            _temperaturaKelvin = ConvertirCelsiusAKelvin(value);
        }
    }

    public void ActualizarLecturaSensor(double nuevaTemperaturaCelsius)
    {
        Console.WriteLine($"[Sensor] Lectura recibida: {nuevaTemperaturaCelsius}°C");
        TemperaturaCelsius = nuevaTemperaturaCelsius;
    }

    public void AplicarAceleracion()
    {
        if (TemperaturaCelsius > 80)
        {
            Console.WriteLine("¡ADVERTENCIA! Sobrecalentamiento. Limitando potencia.");
            // Lógica de protección...
        }
        else
        {
            Console.WriteLine($"Aplicando potencia máxima: {PotenciaMaximaWatts} W");
            // Lógica de aceleración...
        }
    }
}

