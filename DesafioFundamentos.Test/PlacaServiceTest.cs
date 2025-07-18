
using DesafioFundamentos.Services;

namespace DesafioFundamentos.Test
{
    public class PlacaServiceTest
    {
        [Fact]
        public void ValidarPlacaValida()
        {
            // Arrange
            List<string> veiculos = new List<string>();
            var placa = "ABC1D23";
            PlacaService service = new PlacaService();
            // Act
            var resultado = service.PlacaJaExiste(veiculos, placa);
            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void ValidarPlacaExistente()
        {
            // Arrange
            List<string> veiculos = new List<string> { "ABC1D23" };
            var placa = "ABC1D23";
            PlacaService service = new PlacaService();
            // Act
            var resultado = service.PlacaJaExiste(veiculos, placa);
            // Assert
            Assert.True(resultado);
        }
    }
}
