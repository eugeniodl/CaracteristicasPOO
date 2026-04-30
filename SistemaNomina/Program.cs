


Empleado[] empleados =
{
    new EmpleadoPorHoras
    ("Ana", "López", 15.5m, 45),
    new EmpleadoPorComision
    ("Luis", "Ríos", 0.10m, 5000m),
    new EmpleadoBaseMasComision
    ("Marta", "Solís", 0.08m, 8000m,
    1200m)
};

foreach (Empleado emp in empleados)
{
    MostrarIngresos(emp);
    MostrarInformacion(emp);
    DescribirTipo(emp);
}

void DescribirTipo(Empleado emp)
{
    Console.WriteLine($"Tipo real (GetType): " +
        $"{emp.GetType().Name}");
    if (emp is EmpleadoBaseMasComision)
        Console.WriteLine
        ("Este empleado tiene salario base + comisión");
    else if (emp is EmpleadoPorComision)
        Console.WriteLine
        ("Este empleado trabaja solo por comisión");
    else if (emp is EmpleadoPorHoras)
        Console.WriteLine
       ("Este empleado trabaja por horas");
}

void MostrarInformacion(Empleado emp)
{
    Console.WriteLine(emp.ObtenerInformacion());
}

void MostrarIngresos(Empleado emp)
{
    Console.WriteLine($"{emp.NombreCompleto} " +
        $"gana: ${emp.CalcularIngresos():F2}");
}