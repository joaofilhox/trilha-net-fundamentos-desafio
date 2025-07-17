
namespace DesafioFundamentos.Services
{
    public class PlacaService
    {
        public bool PlacaJaExiste(List<string> veiculos, string placa)
        {
            foreach (string p in veiculos)
            {
                if (p == placa)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
