
using DesafioFundamentos.Services;

namespace DesafioFundamentos.Test
{
    public class VeiculosServiceTest
    {
        [Fact]
        public void DeveRetornarListaComVeiculos()
        {
            // Arrange
            var veiculos = new List<string> { "ASD1234", "ABC1234" };
            var service = new VeiculosService();

            // Act
            var resultado = service.ListarVeiculos(veiculos);

            // Assert
            Assert.Equal(2, resultado.Count);
            Assert.Contains("ASD1234", resultado);
        }
    }
}
