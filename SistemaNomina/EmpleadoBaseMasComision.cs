public class EmpleadoBaseMasComision : EmpleadoPorComision
{
    private decimal _salarioBase;

    public decimal SalarioBase
    {
        get => _salarioBase;
        private set
        {
            if (value < 0)
                throw new ArgumentException
            ("El salario base no puede ser negativo");
            _salarioBase = value;
        }
    }

    public EmpleadoBaseMasComision(string nombre, string apellido, 
        decimal tarifaComision, decimal ventasBrutas, decimal salarioBase) 
        : base(nombre, apellido, tarifaComision, ventasBrutas)
    {
        SalarioBase = salarioBase;
    }

    public override decimal CalcularIngresos()
    {
        return base.CalcularIngresos() + SalarioBase;
    }

    public override string MostrarInformacion()
    {
        return $"Empleado con salario base más comisión: {NombreCompleto} | " +
               $"{TarifaComision:P0} sobre ${VentasBrutas:N0} | " +
               $"Salario base: ${SalarioBase:N2}\n";
    }
}