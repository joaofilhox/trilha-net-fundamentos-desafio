
namespace DesafioFundamentos.Services
{
    public class VeiculosService
    {
        public List<string> ListarVeiculos(List<string> veiculos)
        { 
         foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo}");
            }
         return veiculos;
        }
    }
}
