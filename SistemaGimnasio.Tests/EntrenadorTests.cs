using Xunit;
using SistemaGimnasio.Models;

namespace SistemaGimnasio.Tests
{
    public class EntrenadorTests
    {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsuarioALaLista()
        {
            var entrenador = new Entrenador("Paula", "Resistencia");
            var usuario = new Usuario("Luis", 22, "Fuerza");

            entrenador.AsignarUsuario(usuario);

            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
