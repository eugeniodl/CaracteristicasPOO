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
            Console.WriteLine("Estudiantes matriculados en el curso:");
            for (int i = 0; i < _contador; i++)
            {
                Console.WriteLine($"- { _estudiantes[i].Nombre} " +
                    $"({_estudiantes[i].Identificacion})");
            }
    }
}
