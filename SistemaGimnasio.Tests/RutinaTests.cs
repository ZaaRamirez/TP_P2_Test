using Xunit;
using SistemaGimnasio.Models;

namespace SistemaGimnasio.Tests
{
    public class RutinaTests
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista()
        {
            var rutina = new Rutina("Básica", 30);
            var ejercicio = new Ejercicio("Sentadillas", 15, 3, 60);
            var ejercicio2 = new Ejercicio("Lagarijas", 15, 3, 60);

            rutina.AgregarEjercicio(ejercicio);
            rutina.AgregarEjercicio(ejercicio2);

            Assert.NotEmpty(rutina.ObtenerEjercicios());
        }
    }
}
