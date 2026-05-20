var procesadorPagos = new ProcesadorPagos();

MetodoPago pagoTarjeta = new PagoTarjetaCredito
    ("USD", 100.00m, "1234567890123456");
MetodoPago pagoTransferencia = new PagoTransferenciaBancaria
    ("EUR", 200.00m);
MetodoPago pagoCripto = new PagoCriptomenda
    ("BTC", 0.5m, "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa");

procesadorPagos.ProcesarPago(pagoTarjeta);
procesadorPagos.ProcesarPago(pagoTransferencia);
procesadorPagos.ProcesarPago(pagoCripto);
