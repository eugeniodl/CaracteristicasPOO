/// <summary>
/// Clase robusta que cumple con el Principio de Encapsulación (La Caja Negra - Página 5).
/// </summary>
public class CuentaBancaria
{
    // Mandamiento 1 (Página 13): Privacidad Estricta.
    // Usamos un campo 'private' como respaldo.
    // Usamos 'decimal' que es el tipo estándar para dinero en C#.
    private decimal _saldo;

    // Mandamiento 2: Inicialización Segura mediante Constructor.
    public CuentaBancaria(string nombreTitular)
    {
        NombreTitular = nombreTitular; // Asignación a propiedad auto-implementada
        _saldo = 0m;
        EstadoActivo = true;
    }

    // --- CAPA PROTECTORA (Página 7): Propiedades Públicas ---

    // Propiedad de solo lectura (Getter público, Setter privado).
    // Permite que el mundo exterior vea el nombre, pero solo la clase lo modifique.
    public string NombreTitular { get; private set; }

    // Propiedad con lógica de validación en el Setter (Página 8).
    // Protege la integridad del estado.
    private bool _estadoActivo;
    public bool EstadoActivo
    {
        get => _estadoActivo;
        private set => _estadoActivo = value;
    }

    // Getter de SALDO: Acceso controlado de LECTURA.
    // El mundo exterior NO puede hacer "cuenta.Saldo = X". Solo puede leerlo.
    // Esto cumple con "Superficie Mínima" (Página 13).
    public decimal Saldo
    {
        get => _saldo;
        // ¡Atención! NO HAY SETTER PÚBLICO.
        // La única forma de cambiar el saldo es mediante los métodos de comportamiento.
        private set => _saldo = value;
    }

    // --- MÉTODOS DE COMPORTAMIENTO (Setters semánticos) ---
    // Estos métodos son las "únicas puertas autorizadas" (Página 7).

    /// <summary>
    /// Depositar dinero. Rechaza datos absurdos (Página 8).
    /// </summary>
    public void Depositar(decimal monto)
    {
        if (!EstadoActivo)
            throw new InvalidOperationException("No se puede operar en una cuenta inactiva.");

        // Validación de integridad (Protección contra negativos o ceros)
        if (monto <= 0)
            throw new ArgumentException("El monto a depositar debe ser positivo.", nameof(monto));

        _saldo += monto;
        Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${Saldo:N2}");
    }

    /// <summary>
    /// Retirar dinero. Aplica reglas de negocio.
    /// </summary>
    public void Retirar(decimal monto)
    {
        if (!EstadoActivo)
            throw new InvalidOperationException("Cuenta inactiva.");

        if (monto <= 0)
            throw new ArgumentException("Monto inválido.", nameof(monto));

        // Protección de Saldo Insuficiente (Control de Estado - Página 3)
        if (monto > _saldo)
            throw new InvalidOperationException($"Fondos insuficientes. Saldo actual: ${Saldo:N2}");

        _saldo -= monto;
        Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${Saldo:N2}");
    }

    // Beneficio del Ocultamiento de Información (Página 9):
    // Si mañana cambiamos "_saldo" por un tipo "long" (centavos) para optimizar rendimiento,
    // el código cliente que llama a "Depositar" y lee "Saldo" NO SE ROMPE.
}
