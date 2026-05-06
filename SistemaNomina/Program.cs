


Empleado[] nomina =
{
    new EmpleadoPorComision("Juan", "Pérez", 0.1m, 5000m),
    new EmpleadoBaseMasComision("María", "Gómez", 0.05m, 10000m, 3000m),
    new EmpleadoPorHoras("Carlos", "López", 15m, 45)
};

foreach (Empleado empleado in nomina)
{
    MostrarInformacion(empleado);
    MostrarIngresos(empleado);
    DescubrirTipo(empleado);
}

void DescubrirTipo(Empleado empleado)
{
    Console.WriteLine($"Tipo real (GetType): {empleado.GetType().Name}");

    if(empleado is EmpleadoPorComision)
        Console.WriteLine("Es un EmpleadoPorComision");
    else if (empleado is EmpleadoBaseMasComision)
        Console.WriteLine("Es un EmpleadoBaseMasComision");
    else if (empleado is EmpleadoPorHoras)
        Console.WriteLine("Es un EmpleadoPorHoras");
     else
        Console.WriteLine("Tipo de empleado desconocido");
}

void MostrarIngresos(Empleado empleado)
{
    Console.WriteLine($"{empleado.NombreCompleto} " +
        $"gana: ${empleado.CalcularIngresos():N2}");
}

void MostrarInformacion(Empleado empleado)
{
    Console.WriteLine(empleado.MostrarInformacion());
}