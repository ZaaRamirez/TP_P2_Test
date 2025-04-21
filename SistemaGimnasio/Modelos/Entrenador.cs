namespace SistemaGimnasio.Models
{
    public class Entrenador
    {
        public string Nombre { get; private set; }
        public string Especialidad { get; private set; }
        private List<Usuario> usuariosAsignados;

        public Entrenador(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
            usuariosAsignados = new List<Usuario>();
        }

        public void AsignarUsuario(Usuario usuario)
        {
            usuariosAsignados.Add(usuario);
        }

        public List<Usuario> ObtenerUsuariosAsignados()
        {
            return usuariosAsignados;
        }
    }
}

