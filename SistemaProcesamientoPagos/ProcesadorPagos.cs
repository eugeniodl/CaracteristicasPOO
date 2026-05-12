public class ProcesadorPagos
{
    public void Procesar(MetodoPago pago)
    {
        Console.WriteLine(pago.ObtenerDescripcion());
        Console.WriteLine($"Subtotal: {pago.MontoBase:C}");
        Console.WriteLine($"Total con comisión: " +
            $"{pago.CalcularTotal():C}");
        Console.WriteLine($"Total con impuesto extra: " +
            $"{pago.CalcularTotal(2.50m):C}");
        Console.WriteLine("---------------");
    }

   // public class PagoCriptoHijo : PagoCriptoMoneda { }
}

