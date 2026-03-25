/// <summary>
/// Representa una clase base para una persona con información de identificación.
/// </summary>
/// <remarks>Esta clase abstracta proporciona propiedades comunes para los tipos derivados que representan individuos, como
/// nombre e identificación. Hereda de esta clase para implementar roles o comportamientos específicos para diferentes tipos de
/// personas.</remarks>
public abstract class Persona
{
    // Campos privados
    private string? _nombre;
    private string? _identificacion;

    // Propiedades
    public string? Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _nombre = value;
        }
    }

    public string? Identificacion
    {
        get { return _identificacion; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _identificacion = value;
        }
    }

    // Método abstracto
    public abstract void MostrarRol();
}