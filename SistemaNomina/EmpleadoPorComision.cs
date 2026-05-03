public class EmpleadoPorComision : Empleado
{
    private decimal _tarifaComision;
    private decimal _ventasBrutas;

    public decimal TarifaComision
    {
        get => _tarifaComision;
        private set
        {
            if (value < 0 || value > 1)
                throw new ArgumentOutOfRangeException
            ("La tarifa de comisión debe estar entre 0 y 1");
            _tarifaComision = value;
        }
    }

    public EmpleadoPorComision(string nombre, 
        string apellido, decimal tarifaComision,
        decimal ventasBrutas) : base(nombre, apellido)
    {
    }

    public override decimal CalcularIngresos()
    {
        throw new NotImplementedException();
    }
}