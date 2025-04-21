public class Rutina
{
    public string nombre;
    public int duracion;
    public List<string> ejercicios = new List<string>();

    public void AgregarEjercicio(string e)
    {
        ejercicios.Add(e);
    }
}

public class Usuario
{
    public string n;
    public int e;
    public string o;
    public Rutina r;
}

public class Entrenador
{
    public string nom;
    public string esp;
    public List<Usuario> usuarios = new List<Usuario>();
}

static void Main(string[] args)
{
    Console.WriteLine("Bienvenido al sistema");

    Usuario u = new Usuario();
    u.n = "Pepe";
    u.e = 25;
    u.o = "Fuerza";

    Rutina r = new Rutina();
    r.nombre = "Rutina1";
    r.duracion = 30;
    r.AgregarEjercicio("Press banca");
    r.AgregarEjercicio("Sentadillas");
    r.AgregarEjercicio("Abdominales");

    u.r = r;

    Entrenador t = new Entrenador();
    t.nom = "Luis";
    t.esp = "Fuerza";
    t.usuarios.Add(u);

    Console.WriteLine("Usuario: " + u.n);
    Console.WriteLine("Edad: " + u.e);
    Console.WriteLine("Objetivo: " + u.o);
    Console.WriteLine("Rutina asignada: " + u.r.nombre + " (" + u.r.duracion + " mins)");
    foreach (var x in r.ejercicios)
    {
        Console.WriteLine("Ejercicio: " + x);
    }

    Console.WriteLine("Entrenador: " + t.nom + " (" + t.esp + ")");