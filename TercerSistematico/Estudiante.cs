public class Estudiante
{
    private string? _nombre;
    private double _calificacion;

    public Estudiante(string nombre, double calificacion)
    {
        Nombre = nombre;
        Calificacion = calificacion;
    }

    public string? Nombre
    {
        get => _nombre;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            _nombre = value;
        }
    }

    public double Calificacion
    {
        get => _calificacion;
        private set
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException
                    ("La calificación debe estar entre 0 y 100.");
            _calificacion = value;
        }
    }

    public bool Aprobado
    {
        get => Calificacion >= 60;
    }

    public string Estado
    {
        get
        {
            if (Calificacion >= 90)
                return "Excelente";
            else if (Calificacion >= 80)
                return "Muy Bueno";
            else if (Calificacion >= 70)
                return "Bueno";
            else if (Calificacion >= 60)
                return "Suficiente";
            else
                return "Reprobado";
        }
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"{Nombre}: {Calificacion:F1} - {Estado}");
    }
}