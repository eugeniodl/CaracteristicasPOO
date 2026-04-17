var cuenta = new CuentaPremium("ES-1235-5666");

//cuenta.Saldo = 99999

cuenta.AplicarBeneficioExclusivo();
cuenta.Depositar(200);

Console.WriteLine($"Saldo final: {cuenta.Saldo:C}");