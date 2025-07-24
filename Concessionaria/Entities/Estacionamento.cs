
namespace Concessionaria.Entities
{
    public class Estacionamento
    {
        public double ValorHora { get; set; }
        public double ValorInicial { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public Estacionamento(double valorHora, double valorInicial)
        {
            ValorHora = valorHora;
            ValorInicial = valorInicial;
            Veiculos = new List<Veiculo>();
        }
    }
}