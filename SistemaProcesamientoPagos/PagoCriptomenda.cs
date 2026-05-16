public sealed class PagoCriptomenda : MetodoPago
{
    public PagoCriptomenda(string moneda, 
        decimal montoBase) : base(moneda, montoBase)
    {
    }

    public override decimal CalcularComision()
    {
        throw new NotImplementedException();
    }
}

