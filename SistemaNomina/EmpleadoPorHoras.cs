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
            ("El sueldo por hora debe ser mayor a 0");
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
            ("Las horas trabajadas no pueden ser negativas");
            if(value > 744) // 744 es el número máximo de horas en un mes (31 días * 24 horas)
                throw new ArgumentException
            ("Las horas trabajadas no pueden exceder las 744 horas mensuales");
            _horasTrabajadas = value;
        }
    }

    public EmpleadoPorHoras(string nombre, string apellido, 
        decimal sueldoPorHora, 
        int horasTrabajadas)
        : base(nombre, apellido)
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public EmpleadoPorHoras(string nombreCompleto, decimal sueldoPorHora, int horasTrabajadas)
        : base(nombreCompleto)
    {
        SueldoPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
        Console.WriteLine($"-> EmpleadoPorHoras creado desde nombre completo");
    }

    public EmpleadoPorHoras(int horasTrabajadas) : this
        ("Temporal", "Horas", 10.0m, horasTrabajadas )
    {
        Console.WriteLine($"-> Constructor de emergencia: empleado temporal por horas");
    }

    public override decimal CalcularIngresos()
    {
        const decimal HORAS_NORMALES = 40;
        const decimal FACTOR_HORAS_EXTRA = 2.0m;

        if(HorasTrabajadas <= HORAS_NORMALES)
            return SueldoPorHora * HorasTrabajadas;
        else
        {
            decimal horasExtra = HorasTrabajadas - HORAS_NORMALES;
            return (SueldoPorHora * HORAS_NORMALES) + 
                   (SueldoPorHora * FACTOR_HORAS_EXTRA * horasExtra);
        }
    }

    public override string MostrarInformacion()
    {
        return $"Empleado por horas: {NombreCompleto} " +
            $"| ${SueldoPorHora:N2} por hora | " +
            $"{HorasTrabajadas} horas trabajadas\n";
    }

    public decimal CalcularIngresos(int horasExtrasPresupuestadas)
    {
        decimal ingresosBase = CalcularIngresos();
        decimal ingresosExtra = SueldoPorHora * 2.0m * horasExtrasPresupuestadas;
        return ingresosBase + ingresosExtra;
    }
}