var procesadorPagos = new ProcesadorPagos();

MetodoPago tarjeta = 
    new PagoTarjetaCredito("USD", 100.00m, "1234-5678-9012-3456");
MetodoPago transferencia = 
    new PagoTransferenciaBancaria("EUR", 200.00m);
MetodoPago cripto = 
    new PagoCriptoMoneda("BTC", 0.5m, "0xAbC1234Ef5678Gh9iJkLmNopQrStUvWxYz");

procesadorPagos.Procesar(tarjeta);
procesadorPagos.Procesar(transferencia);
procesadorPagos.Procesar(cripto);
