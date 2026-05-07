Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                      SISTEMA DE NÓMINA                     ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
Console.ResetColor();

Empleado[] empleados =
{
    new EmpleadoPorHoras("Ana", "López", 15.5m, 45),
    new EmpleadoPorHoras("Carlos Ruiz", 18.0m, 38),
    new EmpleadoPorHoras(30),
    new EmpleadoPorComision("Luis", "Ríos", 0.010m, 5000m),
    new EmpleadoBaseMasComision("Marta", "Solís", 0.08m, 8000m, 1200m)
};

foreach (Empleado e in empleados)
{
    MostrarIngresos(e);
    MostrarInformacion(e);
    DescubrirTipo(e);
}

void DescubrirTipo(Empleado e)
{
    Console.WriteLine($"Tipo real (GetType): {e.GetType().Name}");
    if (e is EmpleadoBaseMasComision)
        Console.WriteLine("Este empleado tiene salario base + comision");
    else if (e is EmpleadoPorComision)
        Console.WriteLine("Este empleado trabaja solo por comisión");
    else if (e is EmpleadoPorHoras)
        Console.WriteLine("Este empleado trabaja por horas");
}

void MostrarInformacion(Empleado e)
{
    Console.WriteLine(e.ObtenerInformacion());
}

void MostrarIngresos(Empleado e)
{
    Console.WriteLine($"{e.NombreCompleto} " +
        $"gana: {e.CalcularIngresos():F2}");
}