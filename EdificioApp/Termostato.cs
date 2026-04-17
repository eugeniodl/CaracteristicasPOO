// Código bajo análisis crítico (Caso #3)
public class Termostato
{
    private double _temperaturaObjetivo;
    private readonly double _temperaturaMinima;
    private readonly double _temperaturaMaxima;
    private readonly double _incrementoEstandar;

    // Control de tasa sin cambio
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
        if(valor < _temperaturaMinima)
        {
            Console.WriteLine($"[AVISO] {valor:F1}°C es demasiado bajo." +
                $"Ajustando a mínimo {_temperaturaMinima}°C");
            return _temperaturaMinima;
        }
        if (valor > _temperaturaMaxima)
        {
            Console.WriteLine($"[AVISO] {valor:F1}°C es demasiado alto." +
                $"Ajustando a máximo {_temperaturaMaxima}°C");
            return _temperaturaMaxima;
        }
        return valor;
    }

    public double TemperaturaObjetivo
    {
        get => _temperaturaObjetivo;
    }

    public double TemperaturaMinima { get  => _temperaturaMinima; }
    public double TemperaturaMaxima { get  => _temperaturaMaxima; }

    public void SubirTemperatura()
    {
        ModificarTemperatura(_incrementoEstandar);
    }

    private void ModificarTemperatura(double delta)
    {
        if(!PuedeModificar())
        {

        }
    }

    private bool PuedeModificar()
    {
        DateTime ahora = DateTime.Now;

        if(ahora - _ultimoCambio > _ventanaTiempo)
        {
            _contadorCambios = 0;
        }

        return _contadorCambios < _maxCambiosPorVentana;
    }
}