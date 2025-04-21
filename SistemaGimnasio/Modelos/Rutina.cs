namespace SistemaGimnasio.Models
{
    public class Rutina
    {
        public string Nombre { get; private set; }
        public int Duracion { get; private set; }
        private List<Ejercicio> ejercicios;

        public Rutina(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
            ejercicios = new List<Ejercicio>();
        }

        public void AgregarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }

        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }
    }
}
