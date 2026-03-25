Persona[] personas = {
    new Estudiante { Nombre = "Ana" },
    new Docente { Nombre = "Carlos" }
};

for (int i = 0; i < personas.Length; i++)
{
    personas[i].MostrarRol();
}
