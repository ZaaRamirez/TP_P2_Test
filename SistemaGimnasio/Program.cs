using SistemaGimnasio.Models;
using SistemaGimnasio.Servicios;

Console.WriteLine("=== SISTEMA DE GESTIÓN DE GIMNASIO ===\n");

// Crear usuario
Console.Write("Ingrese el nombre del usuario: ");
var nombreUsuario = Console.ReadLine() ?? "";

Console.Write("Ingrese la edad del usuario: ");
int edadUsuario = int.Parse(Console.ReadLine()??"");

Console.Write("Ingrese el objetivo del usuario (e.g., Fuerza, Resistencia): ");
var objetivoUsuario = Console.ReadLine() ?? "";

var usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

// Crear entrenador
Console.Write("\nIngrese el nombre del entrenador: ");
var nombreEntrenador = Console.ReadLine() ?? "";

Console.Write("Ingrese la especialidad del entrenador: ");
var especialidadEntrenador = Console.ReadLine() ?? "";

var entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

// Crear rutina
Console.Write("\nIngrese el nombre de la rutina: ");
var nombreRutina = Console.ReadLine() ?? "";

Console.Write("Ingrese la duración de la rutina en minutos: ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

var rutina = new Rutina(nombreRutina, duracionRutina);

// Agregar ejercicios a la rutina
Console.Write("\n¿Cuántos ejercicios tendrá la rutina? ");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= numEjercicios; i++)
{
    Console.WriteLine($"\nEjercicio #{i}");

    Console.Write("Nombre del ejercicio: ");
    var nombreEjercicio = Console.ReadLine() ?? "";

    Console.Write("Número de repeticiones: ");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Número de series: ");
    int series = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Tiempo de descanso en segundos: ");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    var ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);
}

// Asignar rutina y entrenador al usuario
var asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

// Mostrar resumen
Console.WriteLine($"\n=== RESUMEN DE ASIGNACIÓN ===");
Console.WriteLine($"Usuario: {usuario.Nombre} ({usuario.Objetivo})");
Console.WriteLine($"Rutina asignada: {usuario.RutinaAsignada.Nombre} ({usuario.RutinaAsignada.Duracion} mins)");

Console.WriteLine("Ejercicios:");
foreach (var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"- {e.Nombre} | Series: {e.Series} x {e.Repeticiones} | Descanso: {e.Descanso} seg");
}

Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} ({entrenador.Especialidad})\n");

Console.WriteLine("Presiona cualquier tecla para finalizar...");
Console.ReadKey();
