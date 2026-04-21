public class CuentaPremium : CuentaBancariaBase
{
    public CuentaPremium(string numeroCuenta) : 
        base(numeroCuenta, 100)
    {
    }

    public void AplicarBeneficioExclusivo()
    {
        Console.WriteLine("Aplicando beneficio " +
            "de cuenta Premium...");
        AcreditarInterno(50m, "Bono Bienvenida Premium");
    }

    protected override void AcreditarInterno(decimal monto, 
        string concepto)
    {
        Console.WriteLine("[Override Premium] " +
            "Aplicando multiplicador 1.1x por fidelidad.");
        base.AcreditarInterno(monto * 1.1m, 
            concepto + " (Multiplicando)");
    }
}
