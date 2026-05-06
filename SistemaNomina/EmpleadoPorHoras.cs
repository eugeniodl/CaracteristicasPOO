public class EmpleadoPorHoras : Empleado
{
    private decimal _sueloPorHora;
    private int _horasTrabajadas;

    public decimal SueloPorHora
    {
        get => _sueloPorHora;
        private set
        {
            if (value <= 0)
                throw new ArgumentException
            ("El sueldo por hora debe ser mayor a 0");
            _sueloPorHora = value;
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
        SueloPorHora = sueldoPorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularIngresos()
    {
        const decimal HORAS_NORMALES = 40;
        const decimal FACTOR_HORAS_EXTRA = 2.0m;

        if(HorasTrabajadas <= HORAS_NORMALES)
            return SueloPorHora * HorasTrabajadas;
        else
        {
            decimal horasExtra = HorasTrabajadas - HORAS_NORMALES;
            return (SueloPorHora * HORAS_NORMALES) + 
                   (SueloPorHora * FACTOR_HORAS_EXTRA * horasExtra);
        }
    }

    public override string MostrarInformacion()
    {
        return $"Empleado por horas: {NombreCompleto} " +
            $"| ${SueloPorHora:N2} por hora | " +
            $"{HorasTrabajadas} horas trabajadas\n";
    }
}