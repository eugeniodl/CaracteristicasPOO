Usuario[] usuarios =
{
    new Estudiante() { Nombre = "Ana" },
    new Docente() { Nombre = "Carlos" }
};

for (int i = 0; i < usuarios.Length; i++)
{
    usuarios[i].MostrarRol();
}