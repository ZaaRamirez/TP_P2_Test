namespace SistemaGimnasio.Models
{
    public class Usuario
    {
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string Objetivo { get; private set; }
        public Rutina RutinaAsignada { get; private set; }

        public Usuario(string nombre, int edad, string objetivo)
        {
            Nombre = nombre;
            Edad = edad;
            Objetivo = objetivo;
        }

        public void AsignarRutina(Rutina rutina)
        {
            RutinaAsignada = rutina;
        }
    }
}
