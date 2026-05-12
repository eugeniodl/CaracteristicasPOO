

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔════════════════════════════════════════════════════╗");
Console.WriteLine("║                SISTEMA DE NÓMINA                   ║");
Console.WriteLine("╚════════════════════════════════════════════════════╝");
Console.ResetColor();

Empleado[] nomina =
{
    new EmpleadoPorHoras("Ana", "López", 15.5m, 45),
    new EmpleadoPorComision("Luis", "Ríos", 0.10m, 5000m),
    new EmpleadoBaseMasComision("Marta", "Solís", 0.08m,
    8000m, 1200m),
    new EmpleadoPorHoras("Carlos Ruiz", 18.0m, 38),
    new EmpleadoPorHoras(30),
    new EmpleadoPorComision("Luis", "Ríos", 8000m),
    new EmpleadoBaseMasComision("Marta Solís", 0.08m, 8000m, 1200m)
};

EmpleadoPorHoras empDemo = new EmpleadoPorHoras("Demo Horas", 20.0m, 40);
Console.WriteLine($"Demo Horas + Horas extras presupuestadas es {empDemo.CalcularIngresos(20):F2}");

foreach (var empleado in nomina)
{
    MostrarIngresos(empleado);
    MostrarInformacion(empleado);
    DescribirTipo(empleado);
}

void DescribirTipo(Empleado emp)
{
    Console.WriteLine($"Tipo real (GetType): {emp.GetType().Name}");

    if(emp is EmpleadoBaseMasComision)
        Console.WriteLine("Este empleado tiene salario base + comisión");
    else if (emp is EmpleadoPorComision)
        Console.WriteLine("Este empleado trabaja solo por comisión");
    else if (emp is EmpleadoPorHoras)
        Console.WriteLine("Este empleado trabaja por horas");
}

void MostrarInformacion(Empleado emp)
{
    Console.WriteLine(emp.ObtenerInformacion());
}

void MostrarIngresos(Empleado emp)
{
    Console.WriteLine($"{emp.NombreCompleto} gana: {emp.CalcularIngresos():F2}");
}