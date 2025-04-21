using Xunit;
using SistemaGimnasio.Models;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Tests
{
    public class AsignadorRutinasTests
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarCorrectamente()
        {
            var usuario = new Usuario("Ana", 30, "Cardio");
            var rutina = new Rutina("Rutina Cardio", 40);
            var asignador = new AsignadorRutinas();

            asignador.AsignarRutinaAUsuario(usuario, rutina);

            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]
        public void AsignarUsuarioAEntrenador_DebeIncluirUsuario()
        {
            var usuario = new Usuario("Miguel", 26, "Definición");
            var entrenador = new Entrenador("Laura", "Definición");
            var asignador = new AsignadorRutinas();

            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
