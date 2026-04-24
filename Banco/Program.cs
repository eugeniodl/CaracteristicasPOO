var cuenta = new CuentaPremium("ES-123-456");

cuenta.AplicarBeneficioExclusivo();
cuenta.Depositar(200);

Console.WriteLine($"Saldo final: {cuenta.Saldo:C}");