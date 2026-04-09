try
{
    // Ejemplo de uso
    InscripcionCurso inscripcion = new InscripcionCurso("Ana Martínez", 120.0, 8);

    inscripcion.MostrarInscripcion();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadLine();
