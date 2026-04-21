var cuenta = new CuentaPremium("ES-1234-5678");

cuenta.AplicarBeneficioExclusivo();
cuenta.Depositar(200);

//cuenta.Saldo = 9999999; // CS0200

Console.WriteLine($"Saldo final: {cuenta.Saldo:C}");