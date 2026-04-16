// Código bajo análisis crítico (Caso #3)
public class Termostato
{
    private double _temperaturaObjetivo;
    private readonly double _temperaturaMinima;
    private readonly double _temperaturaMaxima;
    private readonly double _incrementoEstandar;

    // Control de tasa de cambio
    private DateTime _ultimoCambio;
    private int _contadorCambios;
    private readonly TimeSpan _ventanaTiempo = TimeSpan.FromMinutes(1);
    private readonly int _maxCambiosPorVentana = 5;

    public Termostato(double tempInicial = 21.0, double incremento = 0.5)
    {
        _temperaturaMinima = 10.0;
        _temperaturaMaxima = 35.0;
        _incrementoEstandar = incremento;

        _temperaturaObjetivo = ValidarRango(tempInicial);
        _ultimoCambio = DateTime.Now;
        _contadorCambios = 0;
    }

    private double ValidarRango(double valor)
    {
        if (valor < _temperaturaMinima)
        {
            Console.WriteLine($"[AVISO] {valor:F1}°C está por debajo del " +
                $"mínimo permitido. Ajustando a {_temperaturaMinima}°C.");
            return _temperaturaMinima;
        }
        if (valor > _temperaturaMaxima)
        {
            Console.WriteLine($"[AVISO] {valor:F1}°C está por encima del " +
                $"máximo permitido. Ajustando a {_temperaturaMaxima}°C.");
            return _temperaturaMaxima;
        }
        return valor;
    }

    public double TemperaturaObjetivo
    {
        get => _temperaturaObjetivo;
    }

    public double TemperaturaMinima
    {
        get => _temperaturaMinima;
    }

    public double TemperaturaMaxima
    {
        get => _temperaturaMaxima;
    }

    public void SubirTemperatura()
    {
        ModificarTemperatura(_incrementoEstandar);
    }

    public void BajarTemperatura()
    {
        ModificarTemperatura(-_incrementoEstandar);
    }

    private void ModificarTemperatura(double delta)
    {
        // 1. Verificar tasa de cambio
        if (!PuedeModificarAhora())
        {
          throw new InvalidOperationException($"Demasiados cambios en " +
              $"{_ventanaTiempo.TotalSeconds} segundos. " +
              "Por favor, espere antes de intentar nuevamente.");
        }

        // 2. Calcular el nuevo valor y validar el rango
        double nuevoValor = _temperaturaObjetivo + delta;
        double valorValidado = ValidarRango(nuevoValor);

        // 3. Si hay un cambio real, actualizar el estado
        if(_temperaturaObjetivo != valorValidado)
        {
            _temperaturaObjetivo = valorValidado;
            RegistrarCambio();
                Console.WriteLine($"[OK] Temperatura objetivo ajustada a " +
                    $"{_temperaturaObjetivo:F1}°C.");
            ActivarClimatizacion();
        }
        else
        {
            Console.WriteLine($"[INFO] Temperatura objetivo ya está en " +
                $"{_temperaturaObjetivo:F1}°C. No se realizaron cambios.");
        }
    }

    private void ActivarClimatizacion()
    {
        Console.WriteLine($" -> [HARDWARE] Activando climatización...");
    }

    private void RegistrarCambio()
    {
        DateTime ahora = DateTime.Now;

        if(ahora - _ultimoCambio > _ventanaTiempo)
        {
            _contadorCambios = 0;
        }

        _ultimoCambio = ahora;
        _contadorCambios++;
        Console.WriteLine($"[DEBUG] Cambios en esta ventana: " +
            $"{_contadorCambios}/{_maxCambiosPorVentana}");
    }

    private bool PuedeModificarAhora()
    {
        DateTime ahora = DateTime.Now;

        if(ahora - _ultimoCambio > _ventanaTiempo)
        {
            _contadorCambios = 0;
        }

        return _contadorCambios < _maxCambiosPorVentana;
    }
}