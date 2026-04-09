try
{
    // Ejemplo de uso
    ReservaHotel reserva = new ReservaHotel("Carlos Gómez", 8, 35.0);

    reserva.MostrarReserva();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadLine();
