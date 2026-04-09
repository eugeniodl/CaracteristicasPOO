try
{
    // Ejemplo de uso
    PagoEmpleado empleado = new PagoEmpleado("María López", 45, 5.5);

    empleado.MostrarPago();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadLine();
