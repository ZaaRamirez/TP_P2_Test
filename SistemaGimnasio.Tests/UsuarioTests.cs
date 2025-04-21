using Xunit;
using SistemaGimnasio.Models;

namespace SistemaGimnasio.Tests
{
    public class UsuarioTests
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Carlos", 28, "Definición");
            var rutina = new Rutina("Rutina Avanzada", 60);

            //Act
            usuario.AsignarRutina(rutina);

            //Assert
            Assert.Equal("Rutina Avanzada", usuario.RutinaAsignada.Nombre);
        }
    }
}
