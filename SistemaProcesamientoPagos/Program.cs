var procesador = new ProcesadorPagos();

MetodoPago tarjeta = new PagoTarjetaCredito
    ("USD", 100m, "4111111111111111234");
MetodoPago cripto = new PagoCriptoMoneda
    ("BTC", 0.05m, "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa");
MetodoPago transferencia = new PagoTransferenciaBancaria
    ("EUR", 200m);

procesador.Procesar(tarjeta);
procesador.Procesar(cripto);
procesador.Procesar(transferencia);