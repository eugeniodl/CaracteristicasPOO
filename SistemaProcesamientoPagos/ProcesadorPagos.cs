public class ProcesadorPagos
{
    // public class PagoCriptoHijo : PagoCriptomenda {    }
    public void ProcesarPago(MetodoPago metodoPago)
    {
        Console.WriteLine(metodoPago.ObtenerDescripcion());
        Console.WriteLine($"Subtotal: {metodoPago.MontoBase:C}");
        Console.WriteLine($"Total con comisión: {metodoPago.CalcularTotal():C}");
        Console.WriteLine($"Total con comisión extra: " +
            $"{metodoPago.CalcularTotal(2.50m):C}");
        Console.WriteLine("----------------------------");
    }
}

