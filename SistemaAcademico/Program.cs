Persona[] personas = {
    new Estudiante { Nombre = "Ana" },
    new Docente { Nombre = "Carlos" }
};

Estudiante estudiante = new Estudiante { Nombre = "Ana", Carnet = "2024-001" };
Docente docente = new Docente { Nombre = "Carlos", Especialidad = "Matemáticas" };
Docente docente1 = new Docente();

for (int i = 0; i < personas.Length; i++)
{
    personas[i].MostrarRol();
}
