try
{
    // Crear objeto
    EntradaEvento entrada = new EntradaEvento("Juan Pérez", 6, 20.0);

    // Mostrar información
    entrada.MostrarEntrada();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadLine();

