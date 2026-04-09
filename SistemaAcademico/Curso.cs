/// <summary>
/// Representa un curso que gestiona la matrícula de estudiantes y proporciona métodos para registrar y mostrar a los estudiantes matriculados.
/// </summary>
/// <remarks>Una instancia de Curso mantiene una capacidad fija para la matrícula de estudiantes, determinada durante su creación. Utilice
/// MatricularEstudiante para añadir estudiantes hasta alcanzar la capacidad especificada. La clase no admite la eliminación de estudiantes ni
/// el redimensionamiento dinámico de la lista de matriculados.</remarks>
public class Curso
{
    private Estudiante[] _estudiantes;
    private int _contador;

    public Curso(int capacidad)
    {
        _estudiantes = new Estudiante[capacidad];
        _contador = 0;
    }

    public bool MatricularEstudiante(Estudiante estudiante)
    {
        if (_contador < _estudiantes.Length && estudiante != null)
        {
            _estudiantes[_contador] = estudiante;
            _contador++;
            return true;
        }
        return false;
    }

    public void MostrarEstudiantes()
    {
        for (int i = 0; i < _contador; i++)
        {
            Console.WriteLine(_estudiantes[i].Nombre);
        }
    }
}