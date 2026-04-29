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

    public override decimal CalcularIngresos()
    {
        throw new NotImplementedException();
    }
}