var procesador = new ProcesadorPagos();

MetodoPago tarjeta = new PagoTarjetaCredito("USD", 100m, "1234567890123456");
MetodoPago cripto = new PagoCriptomoneda("ETH", 250m, 
    "0xAbC12345DeF67890aBcD12345Ef67890aBCdEf12");
MetodoPago transferencia = new PagoTransferenciaBancaria("EUR", 500m);

procesador.ProcesarPago(tarjeta);
procesador.ProcesarPago(cripto);
procesador.ProcesarPago(transferencia);
