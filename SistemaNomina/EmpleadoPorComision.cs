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

    public decimal VentasBrutas
    {
        get => _ventasBrutas;
        private set
        {
            if (value < 0)
                throw new ArgumentException
            ("Las ventas brutas no pueden ser negativas");
            _ventasBrutas = value;
        }
    }

    public EmpleadoPorComision(string nombre, 
        string apellido, decimal tarifaComision,
        decimal ventasBrutas) 
        : base(nombre, apellido)
    {
        TarifaComision = tarifaComision;
        VentasBrutas = ventasBrutas;
    }

    public override decimal CalcularIngresos()
    {
        return TarifaComision * VentasBrutas;
    }

    public override string ObtenerInformacion()
    {
        return $"Empleado por Comisión: {NombreCompleto} | " +
            $"{TarifaComision:P0} comisión | " +
            $"${VentasBrutas:N0} en ventas";
    }
}