try
{
    // Ejemplo de uso
    ConsumoEnergia consumo = new ConsumoEnergia("Luis Hernández", 350, 0.18);

    consumo.MostrarConsumo();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadLine();
