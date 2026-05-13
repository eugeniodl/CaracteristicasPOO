


Empleado[] nomina =
{
    new EmpleadoPorComision("Juan", "Pérez", 0.1m, 5000m),
    new EmpleadoBaseMasComision("María", "Gómez", 0.05m, 10000m, 3000m),
    new EmpleadoPorHoras("Carlos", "López", 15m, 45),
    new EmpleadoPorHoras("Ana Ruiz", 18.0m, 38), // Usando constructor con nombre completo
    new EmpleadoPorHoras(50) // Constructor de emergencia para empleado temporal por horas
};

EmpleadoPorHoras empDemo = new EmpleadoPorHoras("Pedro", "Martínez", 20.0m, 45);
Console.WriteLine($"Ingreso normal {empDemo.NombreCompleto}: {empDemo.CalcularIngresos():F2}");
Console.WriteLine($"Ingreso + 10 horas extra {empDemo.NombreCompleto}: " +
    $"{empDemo.CalcularIngresos(10):F2}");

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