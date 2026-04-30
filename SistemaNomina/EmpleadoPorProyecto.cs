public class EmpleadoPorProyecto : Empleado
{
    private decimal _tarifaFijaProyecto;
    private int _cantidadProyectos;

    public decimal TarifaFijaProyecto
    {
        get => _tarifaFijaProyecto;
        private set
        {
            if (value < 0)
                throw new ArgumentException
                    ("La tarifa fija por proyecto no puede ser negativa");
            _tarifaFijaProyecto = value;
        }
    }
    public int CantidadProyectos
    {
        get => _cantidadProyectos;
        private set
        {
            if (value < 0)
                throw new ArgumentException
                    ("La cantidad de proyectos no puede ser negativa");
            _cantidadProyectos = value;
        }
    }

    public EmpleadoPorProyecto(string nombre,
        string apellido,
        decimal tarifa,
        int proyectos)
        : base(nombre, apellido)
    {
        TarifaFijaProyecto = tarifa;
        CantidadProyectos = proyectos;
    }

    public override decimal CalcularIngresos()
    {
        return TarifaFijaProyecto * CantidadProyectos;
    }

    public override string ObtenerInformacion()
    {
        return $"Empleado por Proyecto: {NombreCompleto} | " +
               $"{CantidadProyectos} proyectos | " +
               $"{TarifaFijaProyecto:P0}";
    }
}