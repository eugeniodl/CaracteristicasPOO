public class EmpleadoPorHoras : Empleado
{
    private decimal _sueldoPorHora;
    private int _horasTrabajadas;

    public decimal SueldoPorHora
    {
        get => _sueldoPorHora;
        private set
        {
            if (value <= 0)
                throw new ArgumentException
                 ("El sueldo por hora debe ser " +
                 "mayor a 0");
            _sueldoPorHora = value;
        }
    }

    public int HorasTrabajadas
    {
        get => _horasTrabajadas;
        private set
        {
            if (value < 0)
                throw new ArgumentException
                ("Las horas trabajadas no " +
                "pueden ser negativas");
            if (value > 744) // Máximo horas en un mes
                throw new ArgumentException
                 ("Horas exceden el límite mensual");
            _horasTrabajadas = value;
        }
    }

    public EmpleadoPorHoras(string nombre, 
        string apellido, decimal sueldoPorHora,
        int horasTrabajadas) : 
        base(nombre, apellido)
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public EmpleadoPorHoras(string nombreCompleto,
        decimal sueldoPorHora, int horasTrabajadas) :
        base(nombreCompleto)
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
        Console.WriteLine($"EmpleadoPorHoras creado " +
            $"desde nombre completo");
    }

    public EmpleadoPorHoras(int horasTrabajadas) 
        : this("Temporal", "Horas", 10.0m, 
            horasTrabajadas)
    {
        Console.WriteLine($"Constructor de emergencia: " +
            $"empleado temporal por horas");
    }

    public override decimal CalcularIngresos()
    {
        const decimal HORAS_NORMALES = 40;
        const decimal FACTOR_HORA_EXTRA = 2.0m;

        if (HorasTrabajadas <= HORAS_NORMALES)
            return SueldoPorHora * HorasTrabajadas;
        else
        {
            decimal horasExtras = HorasTrabajadas - HORAS_NORMALES;
            return (SueldoPorHora * HORAS_NORMALES) +
                (SueldoPorHora * FACTOR_HORA_EXTRA * horasExtras);
        }
    }

    public override string ObtenerInformacion()
    {
        return $"Empleado por Horas: {NombreCompleto} | " +
            $"${SueldoPorHora}/hora | {HorasTrabajadas} horas";
    }

    public decimal CalcularIngresos(int horasExtrasPresupuestadas)
    {
        decimal ingresoBase = CalcularIngresos();
        decimal ingresoExtra = SueldoPorHora * 1.5m * horasExtrasPresupuestadas;
        return ingresoBase + ingresoExtra;
    }
}