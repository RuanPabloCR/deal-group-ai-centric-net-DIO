using Concessionaria.Entities;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao estacionamento");
        double valorHora, valorInicial;
        Console.Write("Digite o valor inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o valor por hora: ");
        valorHora = Convert.ToDouble(Console.ReadLine());
        Estacionamento estacionamento = new Estacionamento(valorHora, valorInicial);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar veículo");
            Console.WriteLine("2. Listar veículos");
            Console.WriteLine("3. Remover veículo");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite a placa do veículo: ");
                string placa = Console.ReadLine();
                Veiculo veiculo = new Veiculo(placa);
                estacionamento.Veiculos.Add(veiculo);
                Console.WriteLine("Veículo adicionado com sucesso!");
                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Veículos no estacionamento:");
                foreach (var veiculo in estacionamento.Veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa}");
                }
                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (opcao == 3)
            {
                Console.Write("Digite a placa do veículo a ser removido: ");
                string placa = Console.ReadLine();
                Veiculo veiculo = new Veiculo(placa);

                if (estacionamento.Veiculos.Contains(veiculo))
                {
                    Console.WriteLine("Digite quantas horas o veículo ficou estacionado: ");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    double valorTotal = estacionamento.ValorInicial + (horas * estacionamento.ValorHora);
                    Console.WriteLine($"veiculo removido, valor total a pagar: R$ {valorTotal}");
                    estacionamento.Veiculos.Remove(veiculo);

                }
                else
                {
                    Console.WriteLine("Veículo não encontrado.");
                }
                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
            }
        }
        Console.WriteLine("Programa encerrado.");
    }
}