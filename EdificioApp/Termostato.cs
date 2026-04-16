// Código bajo análisis crítico (Caso #3)
public class Termostato
{
    private double _temperaturaObjetivo;
    private readonly double _temperaturaMinima;
    private readonly double _temperaturaMaxima;
    private readonly double _incrementoEstandar;

    // Control de tasa de cambio para evitar ajustes bruscos
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
            Console.WriteLine($"[AVISO] {valor}°C es demasiado bajo." +
                $" Se ajustará a {_temperaturaMinima}°C.");
            return _temperaturaMinima;
        }
        else if (valor > _temperaturaMaxima)
        {
            Console.WriteLine($"[AVISO] {valor}°C es demasiado alto." +
                $" Se ajustará a {_temperaturaMaxima}°C.");
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
}