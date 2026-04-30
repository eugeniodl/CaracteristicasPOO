Empleado[] empleados =
{
    new EmpleadoPorHoras("Ana", "López",
        15.5m, 45),
    new EmpleadoPorComision("Luis", "Ríos",
        0.10m, 5000m),
    new EmpleadoBaseMasComision(
        "Marta", "Solís", 0.08m, 8000m, 1200m),
    new EmpleadoPorProyecto(
        "Carlos", "García", 0.02m, 3)
};

foreach (Empleado emp in empleados)
{
    MostrarIngresos(emp);
    Console.WriteLine();
    MostrarInformacion(emp);
    Console.WriteLine();
    DescribirTipo(emp);
    Console.WriteLine(new string('-', 40));
}

void MostrarIngresos(Empleado emp)
{
    Console.WriteLine($"{emp.NombreCompleto} gana: " +
        $"{emp.CalcularIngresos():F2}");
}

void MostrarInformacion(Empleado emp)
{
    Console.WriteLine(emp.ObtenerInformacion());
}

void DescribirTipo(Empleado emp)
{
    Console.WriteLine($"Tipo real (GetType): {emp.GetType().Name}");

    if (emp is EmpleadoBaseMasComision)
        Console.WriteLine("Este empleado tiene salario base + comisión");
    else if (emp is EmpleadoPorComision)
        Console.WriteLine("Este empleado trabaja solo por comisión");
    else if (emp is EmpleadoPorHoras)
        Console.WriteLine("Este empleado trabaja por horas");
    else if (emp is EmpleadoPorProyecto)
        Console.WriteLine("Este empleado trabaja por proyecto");
     else
        Console.WriteLine("Tipo de empleado desconocido");
}