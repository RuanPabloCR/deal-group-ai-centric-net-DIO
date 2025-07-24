namespace Concessionaria.Entities
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }
        public override bool Equals(object obj)
        {
            if (obj is Veiculo veiculo)
            {
                return Placa.Equals(veiculo.Placa);
            }
            return false;
        }
    }
}