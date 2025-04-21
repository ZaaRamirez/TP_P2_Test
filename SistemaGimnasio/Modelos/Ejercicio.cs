namespace SistemaGimnasio.Models
{
    public class Ejercicio
    {
        public string Nombre { get; private set; }
        public int Repeticiones { get; private set; }
        public int Series { get; private set; }
        public int Descanso { get; private set; }

        public Ejercicio(string nombre, int repeticiones, int series, int descanso)
        {
            Nombre = nombre;
            Repeticiones = repeticiones;
            Series = series;
            Descanso = descanso;
        }
    }
}

