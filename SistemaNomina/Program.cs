


Empleado empleado1 = new EmpleadoPorHoras("Ana", "López", 15.5m, 45);
Empleado empleado2 = new EmpleadoPorComision("Luis", "Ríos", 0.10m, 5000m);
Empleado empleado3 = new EmpleadoBaseMasComision("Marta", "Solís", 0.08m,
    8000m, 1200m);

MostrarIngresos(empleado1);
MostrarIngresos(empleado2);
MostrarIngresos(empleado3);

MostrarInformacion(empleado1);
MostrarInformacion(empleado2);
MostrarInformacion(empleado3);

DescribirTipo(empleado1);
DescribirTipo(empleado2);
DescribirTipo(empleado3);

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